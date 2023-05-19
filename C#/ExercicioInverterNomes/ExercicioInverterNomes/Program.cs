using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome1, nome2, nome3, nome4, aux;

            Console.Write("Digite um nome #1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite um nome #2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite um nome #3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite um nome #4: ");
            nome4 = Console.ReadLine();

            // Mecanismo para inverter os nomes:

            aux = nome1;
            nome1 = nome4;
            nome4 = aux;
            aux = nome2;
            nome2 = nome3;
            nome3 = aux;

            Console.WriteLine();

            Console.WriteLine("nomes inseridos na sequência invertida: ");

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.WriteLine();

            Console.Write("Precissione a tecla Enter para Finalizar...");
            Console.ReadKey();


        }
    }
}
