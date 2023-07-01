using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Deseja calcular o fatorial de qual numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O fatorial de " + numero + " é: " + Fatorial(numero));

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
        
        static int Fatorial(int num)
        {
            if (num > 0)
            {
                return num * Fatorial(num - 1);
            }

            return 1;

            // Processo:
            // 5 * Fatorial(4);
            // 4 * Fatorial(3);
            // 3 * Fatorial(2);
            // 2 * Fatorial(1);
            // 1 * Fatorial(0);
            // return 1;

        }

    }
}
