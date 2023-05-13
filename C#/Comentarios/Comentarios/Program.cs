using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    internal class Program
    {
        static void Main(string[] args) {

            /**/ // comentario em bloco
            // é para comentar uma linha

            // para mostrar/esconder um trecho de cogido é so colocar #region no começo do bloc e #endregion no final do bloco -> é do proprio Visual Studio

            #region Titulo da Region
            Console.WriteLine("Olá Mundo"); // Esse Metodo WriteLine mostra essa mensagem no console
            Console.ReadKey(); // Ele lê uma tecla clicada
            #endregion

        }
    }
}
