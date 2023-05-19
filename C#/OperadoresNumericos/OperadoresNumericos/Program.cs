using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operadores Numericos

            // int soma = 10 + 2;
            // int subtracao = 7 - 3;
            // int multiplicacao = 5 * 2;
            // int divisao = 10 / 2;
            // int resto = 10 % 2;

            #endregion

            #region Ordem de Prioridade

            // 1º a ser calculado são os ()
            // 2° a ser calculado * ou /
            // 3° a ser calculado + ou -

            // int num1 = 100;
            // int num2 = 10;
            // int num3 = 5;

            // int resultado = (num1 + num2) * num3 / 2; // caso é da mesma ordem de prioridade ele executa a primeira que está na esquerda e depois executa a que está na direita

            #endregion

            #region Operadores de Incremento e Decremento

            // int i = 10;

            // pre decremento, executa antes de um procedimento
            // --i;
            // ++i;

            // pos incremento, executa após de um procedimento
            // i++; // <valor de i> + 1
            // i--; // <valor de i> - 1

            #endregion

            #region Operador de Concatenação

            // string ola = "Olá ";
            // string mundo = "Mundo";
            // string juncao = ola + mundo + " " + 2023;

            // Console.WriteLine(juncao);

            #endregion

            #region Operadores de Atribuição

            // atribuição simples
            // int a = 34;
            // int b = 2;
            // 
            // // atribuição combinada
            // a += b;
            // Console.WriteLine(a);
            // a -= b;
            // Console.WriteLine(a);
            // a *= b;
            // Console.WriteLine(a);
            // a /= b;
            // Console.WriteLine(a);
            // a %= b;
            // Console.WriteLine(a);

            // string nome = "Jonas";
            // nome += " Almeida"; // concatena

            #endregion

            #region Operadores de Igualdade

            // int a = 100;
            // int b = 50;

            // bool resultado = a == (b * 2); // retorna true caso for igual
            // bool resultado2 = (200 / 2) != (100 + 100); // retorna true caso for diferente

            // string nome = "Raphael";
            // bool resultado3 = nome == "Renato";

            #endregion

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
