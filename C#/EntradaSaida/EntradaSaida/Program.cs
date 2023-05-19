using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Alex"); // escreve e quebra a linha para o proximo comando
            // Console.Write("Alex 2"); // Escreve e não quebra a linha para o proximo comando

            // Console.WriteLine("Clique em alguma tecla: ");
            // int codigo = Console.Read(); // retorna o codigo ASC dessa tecla clicada, e ele espera executar o enter para ir para a proxima instrução, e ele retorna apenas do primeiro caractere

            // Console.WriteLine("Numero da tecla clicada: " + codigo);

            Console.Write("Digite algo: ");
            string texto = Console.ReadLine(); // retorna a string digitada

            Console.WriteLine(texto);

            Console.Write("Pressione o Enter Para Fechar...");
            Console.ReadKey(); // captura a letra da tecla, esse metodo aguarda digitar a tecla 

        }
    }
}
