using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Forma a = new Forma();
            Forma b = new Triangulo(); // podemos fazer assim pois o Triangulo herda de Forma
            Forma c = new Circulo(); // são tudo Forma porém com comportamentos diferentes
            Forma d = new Retangulo();

            Console.WriteLine("Forma");
            a.Desenhar();
            Console.WriteLine("Triangulo");
            b.Desenhar();                   
            Console.WriteLine("Circulo");
            c.Desenhar();
            Console.WriteLine("Retângulo");
            d.Desenhar();

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
