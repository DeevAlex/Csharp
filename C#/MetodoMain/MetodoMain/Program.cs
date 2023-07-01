using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
    internal class Program
    {
        // esses argumentos são tudo o que a gente passa no CMD
        static void Main(string[] args)
        {

            // Ex:
            // <Nome do Arquivo.exe> <argumentos que ficaram ali no string[] args>

            // string nome = args[0];
            string senha = "abc";

            if (senha != args[1])
            {
                Console.WriteLine("Acesso Negado!");
            } else
            {
                Console.WriteLine("Olá " + args[0]);
            }

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
