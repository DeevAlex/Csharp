using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Forma // poderia ser abstrata
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        // polimorfismo - muda a forma de como se comporta, como nesse metodo que é virtual, e pode ser sobreescrito com o override
        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando para desenhar...");
        }

        public virtual void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Area: " + area);
        }

    }

    class Circulo : Forma
    {
        // já mudamos o comportamento
        public override void Desenhar()
        {
            base.Desenhar(); // ele reaproveita aquele codigo que está como base na classe Forma
            Console.WriteLine("Desenhando um Circulo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area do Circulo é: " + area);
        }
    }

    class Retangulo : Forma
    {

        public override void Desenhar()
        {
            base.Desenhar(); // 
            Console.WriteLine("Desenhando um Retângulo");
        }

        public override void Area()
        {
            base.Area();
        }

    }

    class Triangulo : Forma
    {

        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Triangulo");
        }

        public override void Area()
        {
            double area = (Largura * Altura) / 2;
            Console.WriteLine("Area do Triangulo é: " + area);
        }

    }
}
