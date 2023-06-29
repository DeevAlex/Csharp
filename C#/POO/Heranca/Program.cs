using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Parte 1

            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            // Herança / Abstração
            c.Acelerar();
            b.Acelerar();

            // o operador sealed - Quando aplicado em uma classe impede que outras classes herdem dela, funciona inversa ao abstract

            #endregion

            #region Parte 2

            Humano hu = new Humano();
            Pessoa p = new Pessoa();
            Homem h = new Homem();

            Console.WriteLine("\nHumano");
            hu.Olhos();
            hu.Cabelos();

            Console.WriteLine("\nPessoa");
            p.Olhos();
            p.Cabelos();

            Console.WriteLine("\nHomem");
            h.Olhos();
            h.Cabelos();

            #endregion

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
