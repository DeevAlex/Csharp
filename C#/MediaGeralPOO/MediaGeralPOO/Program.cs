using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno("Alex", 3);

            a1.InserirNotas();
            Console.WriteLine(a1.CalcularMedia());

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
