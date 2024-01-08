using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;

namespace CriptoFile
{
    internal class Criptografia
    {

        // Declaração de CspParameters e RsaCryptoServiceProvider
        // Objetos com escopo global na classe

        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        // Caminhos variaveis para a fonte, pasta de criptografia
        //e pasta de descriptografia

        private static string _encrFolder;
        public static string EncrFolder { 
            get { return _encrFolder; }
            set {
                _encrFolder = value;
                // Definir o caminho
                PubKeyFile = _encrFolder + "rsaPublicKey.txt";
            } 
        }

        public static string DecrFolder { get; set; }
        public static string SrcFolder { get; set; }

        // Arquivo de chave publica
        private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

        // Chave contendo o nome para private/public key value pair
        public static string keyName;

        // metodo para criar as chaves assimétricas publicas
        public static string CreateAsmKeys()
        {
            string result = "";

            // Armazena uma key pair na key container
            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave Publica não definida";
                return result;
            }

            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true; // vai utilizar o serviço de persistencia

            // retorna se é publica ou não
            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
            } else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

        // Metodo para exportar a chave publica para um arquivo
        public static bool ExportPublicKey()
        {
            bool result = true;

            // nenhuma chave foi definida
            if (rsa == null)
            {
                return false;
            }

            // Verifica se a não pasta está criada
            if (!Directory.Exists(EncrFolder))
            {
                Directory.CreateDirectory(EncrFolder);
            }

            StreamWriter sW = new StreamWriter(PubKeyFile, false);

            try {

                sW.Write(rsa.ToXmlString(false)); // Escreve uma string no formato XML

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                result = false;
            } finally { 
                sW.Close();
            }


            return result;
        }

        // Metodo para importar a chave publica de um arquivo
        public static string ImportPublicKey()
        {

            string result = "";

            if (!File.Exists(PubKeyFile))
            {
                result = "Arquivo de chave publica não encontrado.";
                return result;
            }

            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave publica não definida";
                return result;
            }

            StreamReader sR = new StreamReader(PubKeyFile);

            try
            {
                cspp.KeyContainerName = keyName;
                rsa = new RSACryptoServiceProvider(cspp);

                string keyTxt = sR.ReadToEnd();
                rsa.FromXmlString(keyTxt); // retorna a chave que está no arquivo a partir de uma string XML
                rsa.PersistKeyInCsp = true;

                if (rsa.PublicOnly)
                {
                    result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
                }
                else
                {
                    result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
                }

            }
            catch (Exception ex)
            {
                result = ex.Message;
                Console.WriteLine(ex.Message);
            } finally
            {
                sR.Close();
            }

            return result;

        }

        // Metodo para cria a chave privada à partir de um valor definido
        public static string GetPrivateKey()
        {

            string result = "";

            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave privada não definida";
                return result;
            }

            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;

        }

        // Metodo para criptografar um arquivo
        public static string EncryptFile(string caminhoArquivo)
        {

            // Criar uma instancia de Aes para criptografia simetrica dos dados
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            // Use RSACryptoServiceProvider para criptografar a chave AES.
            // rsa é instanciado anteriormente: rsa = new RSACryptoServiceProvider(cspp);

            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

            // Crie matrizes de bytes para conter
            // os valores de comprimento da chave e IV

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);

            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            // Escreva o seguinte no FileStream
            // para o arquivo criptografado(outFs):
            // - comprimento da chave
            // - comprimento do IV
            // - chave criptografada
            // - o IV
            // - o conteudo da cifra criptografada

            int startFileName = caminhoArquivo.LastIndexOf("\\") + 1;

            string outFile  = EncrFolder + caminhoArquivo.Substring(startFileName) + ".enc";

            try
            {

               using(FileStream outFs = new FileStream(outFile, FileMode.Create))
                {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenIV, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV); // IV - Vetor de Inicialização

                    // Agora escreva o texto cifrado usando um CryptoStream para criptografar

                    using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {

                        // Ao criptografar um pedaço por vez, você pode economizar memoria

                        int count = 0;
                        int offset = 0; // deslocamento, para saber onde estamos

                        // blockSizeBytes pode ter qualquer tamanho arbitrário
                        int blockSizeBytes = aes.BlockSize / 8; // aes.BlockSize retorna o tamanho do bloco que esta sendo criptografado
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream infs = new FileStream(caminhoArquivo, FileMode.Open)) // esse Open, somente abre para leitura 
                        {

                            do
                            {
                                // o read vai ler o arquivo caminhoArquivo
                                count = infs.Read(data, 0, blockSizeBytes); // ele lê um valor começando do indice 0, até o tamanho do blockSizeBytes, e vai armazenar o array data

                                offset += blockSizeBytes; // ele vai aumentando ao ler o conteudo, para saber onde estamos
                                outStreamEncrypted.Write(data, 0, count); // vamos escrever o valor que esta no array data a partir do indice 0 até count
                                bytesRead += blockSizeBytes; // aqui estamos colocando para que a variavel que representa os bytes que foram lidos seja atribuido o valor do tamanho do blockSizeBytes

                            } while (count > 0);

                            infs.Close();

                        }

                        outStreamEncrypted.FlushFinalBlock();
                        outStreamEncrypted.Close();

                    }

                    outFs.Close();
                    File.Delete(caminhoArquivo);

                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return $"Arquivo criptografado.\nOrigem: {caminhoArquivo}\nDestino: {outFile}";

        }

        // Metodo para descriptografar um arquivo
        public static string DecryptFile(string caminhoArquivo)
        {

            // Criar um instancia de AES para descriptográfia simétrica dos dados
            Aes aes = Aes.Create();

            // Crie matrizes de bytes para obter o comprimento da chave criptografada e IV
            // Esses valores foram armazenados como 4 bytes cada no inicio do pacote criptografado

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Construir o nome do arquivo para o arquivo descriptografado
            string outFile = DecrFolder + caminhoArquivo.Substring(0, caminhoArquivo.LastIndexOf("."));

            try
            {
                
                // Use objetos FileStream para ler o arquivo criptografado chamado (inFs) e salve o arquivo descriptografado (outFs)
                using (FileStream inFs = new FileStream(EncrFolder + caminhoArquivo, FileMode.Open))
                {
                    inFs.Seek(0, SeekOrigin.Begin); // Move o ponteiro de leitura para o início do arquivo.
                    inFs.Seek(0, SeekOrigin.Begin);

                    inFs.Read(LenK, 0, 3);

                    inFs.Seek(4, SeekOrigin.Begin); // posicionamos no indice 4 porque já foram lidos os outros 3 indices

                    inFs.Read(LenIV, 0, 3);

                    // Converte os comprimentos em valores inteiros
                    int lenK = BitConverter.ToInt32(LenK, 0);
                    int lenIV = BitConverter.ToInt32(LenIV, 0);

                    // Determine a posição inicial do texto cifrado(startC) e seu comprimento (lenS)
                    int startC = lenK + lenIV + 8; // posicao inicial
                    int lenC = (int) inFs.Length - startC; // inFs.Length, comprimento todo do arquivo cifrado - posicao de começo de leitura do texto cifrado dai temos o tamanho total finalizado do texto cifrado

                    // Crie as matrizes de bytes para a chave Aes criptografadas, o IV e o texto cifrado

                    byte[] KeyEncrypted = new byte[lenK];
                    byte[] IV = new byte[lenIV];

                    // Extraia a chave e o IV começando do indice 8 após os valores de comprimento
                    inFs.Seek(8, SeekOrigin.Begin);
                    inFs.Read(KeyEncrypted, 0, lenK); // estamos armazenando esse valor na KeyEncrypted, começamos do indice 0 até o comprimento da chave criptografada  
                    inFs.Seek(8 + lenK, SeekOrigin.Begin); // reposicionando o ponteiro de leitura pois ja foram lidos o lenK, para que possamos ler a chave
                    inFs.Read(IV, 0, lenIV);

                    if (!Directory.Exists(DecrFolder))
                    {
                        Directory.CreateDirectory(DecrFolder);
                    }

                    // use o RSACryptoServiceProvider para descriptografar a chave AES

                    byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                    // Descriptografe a chave

                    ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                    // Descriptografar o texto cifrado do FileStream do arquivo(inFs) criptografado
                    // no FileStream para o arquivo descriptografado (outFs)

                    using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                    {

                        int count = 0;
                        int offset = 0;

                        // blockSizeBytes pode ter qualquer tamanho arbitrario
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];

                        // Ao descriptrografar um pedaço de cada vez
                        // Você pode economizar memoria e acomodar arquivos grandes

                        // Comece no inicio do texto cifrado
                        inFs.Seek(startC, SeekOrigin.Begin);
                        using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                        {

                            do
                            {

                                count = inFs.Read(data, 0, blockSizeBytes); // Leio
                                offset += count; // Reposiciono
                                outStreamDecrypted.Write(data, 0, count); // Escrevo

                            } while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                            outStreamDecrypted.Close();

                        }

                        outFs.Close();

                    }

                    inFs.Close();

                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return $"Arquivo descriptografado.\nOrigem: {caminhoArquivo}\nDestino: {outFile}";

        }

    }

}
