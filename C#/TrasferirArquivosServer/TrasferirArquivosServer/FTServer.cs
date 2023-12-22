using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrasferirArquivosServer
{
    internal class FTServer
    {

        static IPEndPoint ipEnd_Servidor; // define o ponto de conexão com o servidor
        static Socket soc_servidor; // cria o socket de conexão
        public static string EnderecoIP = "127.0.0.1";
        public static int portaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // a pasta padrão para os arquivos na pasta meus documentos em qualquer computador
        public static ListBox ListaMensagem;

        public static void IniciarServidor()
        {

            try
            {

                ipEnd_Servidor = new IPEndPoint(IPAddress.Parse(EnderecoIP), portaHost);
                soc_servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                soc_servidor.Bind(ipEnd_Servidor); // associa com o endPoint

            } catch (Exception ex)
            {

                // como está em uma Thread diferente e vamos fazer uma alteração SEMPRE devemos usar o Invoke
                ListaMensagem.Invoke(new Action(() => {

                    ListaMensagem.Items.Clear();
                    ListaMensagem.Items.Add("Erro ao iniciar o servidor: " + ex);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true); // para dar um scroll caso passe da area visivel


                }));

                return;

            }

            try
            {

                soc_servidor.Listen(100);
                ListaMensagem.Invoke(new Action(() => {

                    ListaMensagem.Items.Clear();
                    ListaMensagem.Items.Add("Servidor em atendimento e aguardando para receber arquivo...");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true); // para dar um scroll caso passe da area visivel


                }));

                Socket clienteSock = soc_servidor.Accept(); // caso ouça uma requisição ele aceita a conexão e dai a gente cria uma variavel para salvar o socket do cliente
                clienteSock.ReceiveBufferSize = 16384; // ReceiveBufferSize -> é a capacidade que ele consegue trabalhar o padrão dele é 8.000 que é 8Kb

                byte[] dadosCliente = new byte[1024 * 50000]; // 50Mb que o cliente consegue enviar

                int tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, 0, dadosCliente.Length, 0); // obtém todos os dados recebidos do cliente
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0); // ele retira o tamanho do nome do arquivo

                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo); // nome do arquivo recebido do cliente

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArquivo, FileMode.Append)); // Aqui vamos fazer gravar os dados, caso já exista ele adiciona mais conteudo ao arquivo existente (FileMode.Append)
                binaryWriter.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo); // grava as informações

                while(tamanhoBytesRecebidos > 0)
                {
                    tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0); // a cada ciclo passados ele vai pegar o montante de bytes recebidos

                    if (tamanhoBytesRecebidos == 0)
                    {
                        binaryWriter.Close(); // caso terminamos de receber todos os bytes, fechamos o gravador para liberar recursos
                    } else
                    {
                        binaryWriter.Write(dadosCliente, 0, tamanhoBytesRecebidos); // ele vai gravar os dados do cliente, todos os bytes que ele recebeu
                    }

                    ListaMensagem.Invoke(new Action(() => {

                        ListaMensagem.Items.Clear();
                        ListaMensagem.Items.Add("Arquivo recebido e arquivado [" + nomeArquivo + "]");
                        ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true); // para dar um scroll caso passe da area visivel


                    }));
                    
                    binaryWriter.Close(); // fechamos o gravador de dados recebidos
                    clienteSock.Close(); // para fechar a conexão com o cliente

                }


            } catch (SocketException ex) {

                ListaMensagem.Invoke(new Action(() => {

                    ListaMensagem.Items.Clear();
                    ListaMensagem.Items.Add("Erro ao receber arquivo: " + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true); // para dar um scroll caso passe da area visivel


                }));

            } finally
            {
                soc_servidor.Close(); // garantir que o socket foi fechado
                soc_servidor.Dispose(); // se livra de qualquer coisa que tenha ficado
                IniciarServidor(); // iniciando o servidor de forma recursiva, para caso tenha mais arquivos a ser recebidos
            }

        }

    }

}
