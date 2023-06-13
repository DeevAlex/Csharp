using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region While

            // int x = 1; // variavel de controle
            // while (x <= 10) // se for verdadeiro ele executa até ser falsa
            // {
            //    Console.WriteLine(x);
            //    x++; // mecanismo de controle para esse loop não ser infinito 
            // }

            #endregion

            #region Do While

            // int x = 1; // variavel de controle
            // do // executa primeiro, e pelo menos só uma vez se for true ele continua e faz a verificação ali em baixo
            // {
            //    Console.WriteLine(x);
            //    x++;
            // } while (x <= 10); // depois faz a verificação e depois executa o codigo do DO até chegar false

            #endregion

            #region For

            // para criar mais variaveis de controle e para acrescimento ou decrescimento é so colocar ,
            // for (int i = 1, j = 2; i <= 10; i++, j+=2) // nesse caso ele cria a variavel de controle, a verificação e o mecanismo de para não deixar infinito
            // {
            //    Console.WriteLine(i + " | " + j);
            // }

            #endregion

            #region Foreach

            // string[] nomes = { "Alex", "Jonhson", "Donald", "Joe"};

            // foreach (string nome in nomes) { // ele cria uma variavel do tipo do array que será percorrido e vai atribuindo nela, e para no fim do array
            //    Console.WriteLine(nome);
            //    // exemplo de como ocorre: nome = nomes[indice++, começa no zero] 
            // }

            #endregion

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();
        }
    }
}
