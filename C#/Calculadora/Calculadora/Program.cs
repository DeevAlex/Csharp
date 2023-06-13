using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.Clear(); // para limpar o console
            Console.Write("Digite o #1 numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o #2 numero: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o operador: ");
            char operador = char.Parse(Console.ReadLine());

            switch(operador)
            {
                case '+':
                    Console.WriteLine("\n A soma de " + num1 + " + " + num2 + " = " + (num1 + num2) + " \n");
                    break;
                case '-':
                    Console.WriteLine("\n A subtração de " + num1 + " - " + num2 + " = " + (num1 - num2) + " \n");
                    break;
                case '*':
                    Console.WriteLine("\n A multiplicação de " + num1 + " * " + num2 + " = " + (num1 * num2) + " \n");
                    break;
                case '/':
                    Console.WriteLine("\n A divisão de " + num1 + " / " + num2 + " = " + (num1 / num2) + " \n");
                    break;
                case '%':
                    Console.WriteLine("\n A o resto da divisão de " + num1 + " / " + num2 + " = " + (num1 % num2) + " \n");
                    break;
                default:
                    Console.WriteLine("Sinal não reconhecido!");
                    break;

            }

            Console.Write("Deseja continuar? (sim) ou (não): ");
            string continuar = Console.ReadLine().ToLower();

            if (continuar == "sim")
            {
                goto inicio;
            } else
            {
                Console.Write("\nPressione uma tecla para finalizar: ");
                Console.ReadKey();
            }
        }
    }
}
