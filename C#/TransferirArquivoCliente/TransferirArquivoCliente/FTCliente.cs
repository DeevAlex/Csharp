using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    internal class FTCliente
    {

        static IPEndPoint ipEnd_cliente;
        static Socket clienteSocket_cliente;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {

            try
            {

                ipEnd_cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                clienteSocket_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta += arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1); // pegando o nome da pasta ("\nomeDoArquivo")
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1); // pegando somente o nome do arquivo

                // somente o nome do arquivo
                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo); // o getBytes retorna um array de bytes a partir do nome do arquivo

                // vericando o nome do arquivo se é maior de 50Mb
                if (nomeArquivoByte.Length > 50000 * 1024)
                {

                    LabelMensagem.Invoke(new Action(() => {

                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "O tamanho do arquivo é maior que 50Mb, tente um arquivo menor";

                    }));
                    return;

                }

                string caminhoCompleto = pasta + arquivo;

                byte[] fileData = File.ReadAllBytes(caminhoCompleto); // retorna todos os bytes desse arquivo
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length]; // guardando os dados do cliente
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clientData, 0); // copiando para o clientData a partir do indice 0

                nomeArquivoByte.CopyTo(clientData, 4);
                
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);

                clienteSocket_cliente.Connect(ipEnd_cliente); // conectando o socket client com o servidor

                clienteSocket_cliente.Send(clientData, 0, clientData.Length, 0); // enviando o buffer com os dados do cliente, a partir do zero e toda informação

                clienteSocket_cliente.Close(); // fechando esse socket 

                LabelMensagem.Invoke(new Action(() => {

                    LabelMensagem.ForeColor = Color.Green;
                    LabelMensagem.Text = "Arquivo [" + arquivo + "] foi trasferido!";

                }));


            }
            catch (Exception ex)
            {

                LabelMensagem.Invoke(new Action(() => {

                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = "Falha, o servidor não está atendendo... " + ex.Message;

                }));

            }
            finally
            {

                clienteSocket_cliente.Close(); // fechando esse socket, para todos os recursos serem liberados e não ocupem espaço de memoria

            }

        }

    }

}
