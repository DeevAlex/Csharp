using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ele é sincrono

            // AddressFamily.InterNetwork -> indica que usaremos o IPV4
            // SocketType.Stream -> É um tipo de socket responsavel pela comunicação de dados (envio e recebimento de dados de fluxo controlado para que não haja perca de dados) 
            // ProtocolType.Tcp -> Isso define o protocolo que usaremos para trabalhar com o IPV4
            // IP local -> "127.0.0.1"

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Onde vamos nos comunicar
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234); // IP, PORTA (nesse caso é ficticia)

            // Ele associa o socket ao endPoint
            socket.Bind(endPoint);

            // Ele escuta as requisições dos clientes
            socket.Listen(5); // Ele escuta 5 vezes

            Console.WriteLine("Escutando...");

            // Esse accept faz uma conexão com o socket que faz uma requisição
            Socket escutar = socket.Accept();

            // Array que vai pegar os dados da requisição
            byte[] bytes = new byte[255];

            // define o tamanho da nossa mensagem
            int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None); // esse Receive é onde ele vai gravar as informaçoes recebidas, e quanto ele vai pegar, o SocketFlags é para definir o tipo de requisição

            // Esse metodo faz com que caso a requisição seja menor que o tamanho do array e para que não tenha disperdicio de recursos realocamos o tamanho do array para o tamanho da requisição
            Array.Resize(ref bytes, tamanho); // o ref é a referencia do array bytes

            Console.WriteLine("Cliente Falou: ");
            Console.WriteLine(Encoding.Default.GetString(bytes)); // faz uma string a partir do array de bytes

            socket.Close(); // fechando a comunição

            Console.Write("COMUNIÇÃO COM O SERVIDOR FOI FINALIZADA\nPressione qualquer tecla para finalizar: ");
            Console.ReadKey();

        }

    }
}
