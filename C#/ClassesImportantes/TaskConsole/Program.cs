using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // parecido com o thread, Quem executa primeiro, aparece primeiro. (pode ser usado simultâneo

            // Task t1 = new Task(Tarefa);

            // t1.Start();

            // Task t2 = Task.Run(Tarefa);

            // Task.Run(Tarefa);

            Task.Factory.StartNew(Tarefa);

            Task.Run(() => {

                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine("Tarefa Anônima");

                } 

            }); // passando um metodo anonimo

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Tarefa Principal");

            }

            Console.Write("Pressione uma tecla para finalizar a tarefa: ");
            Console.ReadKey();

        }

        static private void Tarefa() // quando programando em console precisa colocar os metodos static
        {

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Tarefa do Task");

            }

        }
    }
}
