using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            try
            {

                // Onde vamos nos comunicar
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234); // IP, PORTA (nesse caso é ficticia)

                socket.Connect(endPoint); // se conecta com o servidor

                Console.WriteLine("Você foi conectado com sucesso!");
                Console.WriteLine("Insira a informação para enviar: ");
                Console.WriteLine();

                string info = Console.ReadLine();

                byte[] infoEnviar = Encoding.UTF8.GetBytes(info); // formatando a informação em um array de bytes para que possa ser enviada atraves do nosso socket

                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None); // ele pega desde o começo da informação até o fim e envia 


            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possivel conectar com o servidor...");
            }

            socket.Close(); // Fechar a conexão

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();
            
        }

    }
}
