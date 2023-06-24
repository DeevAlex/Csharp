using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Encapsular - é separar o programa em partes isoladas possiveis, 
            // Encapsulamento - é o processo de ocultar/esconder os membros de uma classe do acesso exterior usando modificadores de acesso

            Conta c = new Conta();

            c.Cliente = "Alex";
            // c.Saldo = 100; - só pode ser mudado dentro da classe, pois o set está private

            c.Depositar(500);
            c.Sacar(150);

            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
