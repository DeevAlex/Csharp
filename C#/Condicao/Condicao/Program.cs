using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Estrutura Condicional Simples

            // int valor = 5;
            // if (valor > 5)
            // {
            //    Console.WriteLine("Condição Verdadeira");
            // }
            // else
            // {
            //    Console.WriteLine("Condição Falsa");
            // }

            #endregion

            #region Estrutura Condicional Encadeada

            // int valor = 15;
            // if (valor < 5)
            // {
            //    Console.WriteLine("Condição Verdadeira");
            // }
            // else if (valor >= 10 && valor < 10) {

            //    Console.WriteLine("Condição alternativa 1");

            // } else if (valor >= 10 && valor < 20) {

            //    Console.WriteLine("Condição alternativa 2");

            // } else {

            //    Console.WriteLine("Condição alternativa final");

            // }

            #endregion

            #region Estrutura Condicional Aninhada

            // int numero = 15;

            // if (numero > 5)
            // {
            //    Console.Write("O numero é maior que 5 ");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine("e também é PAR");
            //    } else
            //    {
            //        Console.WriteLine("e também é IMPAR");
            //    }
            // }

            #endregion

            #region Operador Ternário

            // int numero = 10;
            // operador ternario -> condição ? true : false;
            // string mensagem = numero > 5 ? mensagem = "maior que 5" : mensagem = "menor que 5"; ;

            // if normal
            // if (numero > 5)
            // {
            //    mensagem = "maior que 5";
            // } else
            // {
            //    mensagem = "menor que 5";
            // }

            #endregion

            // Console.WriteLine(mensagem);

            Console.ReadKey();
        }
    }
}
