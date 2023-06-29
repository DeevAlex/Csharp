using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teste t = new Teste();

            // public
            // t.nome = ""; // private
            t.sobrenome = ""; // public
            // t.Metodo1(); // private 
            t.Executar();

            Homem h = new Homem(); // seria visivel se usasse-mos uma dll externa

            h.idade = 19; // porém não isso não poderia ser feito, pois estaria dentro daquela compilação

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
