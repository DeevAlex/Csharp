using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // recursividade, é o processo de ele se auto-executar para executar certa tarefa

            Recursiva r1 = new Recursiva();

            r1.Executar("Olá Mundo", 5);

            r1.ExecutarRecursivo("RECURSIVIDADEEE", 5);

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
