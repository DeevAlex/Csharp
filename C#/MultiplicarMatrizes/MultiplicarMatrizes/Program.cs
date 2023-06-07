using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2,3]; // matriz com duas linhas e 3 colunas
            int[,] matriz2 = new int[3,2]; // matriz com três linhas e 2 colunas
            int[,] resultado = new int[2,2]; // matriz com duas linhas e 2 colunas

            Console.WriteLine("Preencha a #1 matriz");

            // percorre todas as linhas
            for(int linha = 0; linha < 2; linha++)
            {
                // percorre todas as colunas
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencha a #2 matriz");

            // percorre todas as linhas
            for (int linha = 0; linha < 3; linha++)
            {
                // percorre todas as colunas
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2. Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nO resultado da matriz #1 x matriz2:");

            resultado[0,0] = (matriz1[0,0] * matriz2[0,0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultado[1,0] = (matriz1[1,0] * matriz2[0,0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultado[0,1] = (matriz1[0,0] * matriz2[0,1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultado[1,1] = (matriz1[1,0] * matriz2[0,1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0,0] + "][" + resultado[0,1]+"]");
            Console.WriteLine("[" + resultado[1,0] + "][" + resultado[1,1]+"]");

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
