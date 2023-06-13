using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite seu Peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite seu Altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("\nSeu IMC: " + imc + ", está abaixo do peso");
            }
            else if ((imc >= 20) && (imc <= 24))
            {
                Console.WriteLine("\nSeu IMC: " + imc + ", está normal");
            } 
            else if ((imc >= 25) && (imc <= 29))
            {
                Console.WriteLine("\nSeu IMC: " + imc + ", está acima do peso");
            }
            else if ((imc >= 30) && (imc <= 34))
            {
                Console.WriteLine("\nSeu IMC: " + imc + ", está obeso");
            }
            else
            {
                Console.WriteLine("\nSeu IMC: " + imc + ", está muito obeso");
            }

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
