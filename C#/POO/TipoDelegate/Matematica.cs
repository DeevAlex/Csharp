using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {

        public void Somar(double num1, double num2)
        {
            Console.WriteLine("O resultado da soma foi: " + (num1 + num2));
        }

        public void Subtrair(double num1, double num2)
        {
            Console.WriteLine("O resultado da subtração foi: " + (num1 - num2));
        }

        public void Multiplicar(double num1, double num2)
        {
            Console.WriteLine("O resultado da multiplição foi: " + (num1 * num2));
        }

        public void Dividir(double num1, double num2)
        {
            Console.WriteLine("O resultado da divisão foi: " + (num1 / num2));
        }

    }
}
