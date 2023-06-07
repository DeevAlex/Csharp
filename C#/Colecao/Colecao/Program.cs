using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Vetores

            // declarando um Array de x posições:
            //int[] numeros = new int[5];

            //// atribuindo valores nas posições:
            //numeros[0] = 0;
            //numeros[1] = 1;
            //numeros[2] = 2;
            //numeros[3] = 3;
            //numeros[4] = 4;

            //// reatribuindo um valor x na posição y
            //numeros[2] = 5;

            //string[] nomes = new string[5];

            //nomes[0] = "Alex";
            //nomes[1] = "Bianca";
            //nomes[2] = "Mario";

            // Iniciando e Atribuindo valores a um array
            //       indices:        0          1
            //string[] filmes = { "Harry Potter", "Homem de Ferro" };

            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(nomes[2]);
            //Console.WriteLine(filmes[1]);
            //Console.Write("Pressione uma Tecla...");
            //Console.ReadKey();

            #endregion


            #region Matrizes

            // Definindo uma matriz:
            
            int[,] numeros = new int[3, 3]; // matriz com 3 linhas e 3 colunas

            // para preencher essa matriz:

            // [linha, coluna]
            numeros[0,0] = 1;
            numeros[0,1] = 2;
            numeros[0,2] = 3;

            numeros[1, 0] = 4;
            numeros[1, 1] = 5;
            numeros[1, 2] = 6;

            numeros[2, 0] = 7;
            numeros[2, 1] = 8;
            numeros[2, 2] = 9;

            string[,] nomes =
            {
                // coluna
              { "Alex", "Gabriel", "Jonas" },  // a primeira linha vai definir as configurações das futuras linhas
              { "Silvana", "Marina", "Laysa" }, // linhas
            };

            Console.Write("[" + numeros[0, 0] + ", " + numeros[0, 1] + ", " + numeros[0, 2] + "]\n");
            Console.Write("[" + numeros[1, 0] + ", " + numeros[1, 1] + ", " + numeros[1, 2] + "]\n");
            Console.Write("[" + numeros[2, 0] + ", " + numeros[2, 1] + ", " + numeros[2, 2] + "]\n");

            // [1, 2, 3]
            // [4, 5, 6]
            // [7, 8, 9]

            Console.WriteLine(nomes[0, 1]);

            Console.Write("Pressione Qualquer Tecla...");
            Console.ReadKey();

            #endregion

        }
    }
}
