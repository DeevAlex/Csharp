using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Metodos m = new Metodos(); // instanciando a classe Métodos

            #region Método Simples

            // Método Simples
            m.Cumprimentar();

            #endregion

            #region Método com parametros

            // Método com Parâmetros
            m.Apresentar("Alex", 19);
            m.Calculadora(5, 5, '*');

            #endregion

            #region Passagem de Parametros por Valor e Referencia

            // Passagem de parâmetros por valor

            Console.WriteLine("");

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1); // passando uma copia do valor da variavel
            Console.WriteLine(valor1);

            // Passagem de parâmetros por referência

            m.AumentarRef(ref valor2); // tem que colocar esse ref aqui também para não dar erro
            Console.WriteLine(valor2);

            Console.WriteLine("");

            #endregion

            // Métodos com retorno de valores

            Console.WriteLine(m.MontaNome("São", "Gonsalo"));
            Console.WriteLine(m.CodigoChar('a'));
            Console.WriteLine(m.ValorPi());

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
