using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Switch Case

            // int escolha = 1;
            // switch (escolha)
            // {
            //    case 1:
            //        Console.WriteLine("Opção 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Opção 2");
            //        break;
            //    case 4: // pode colocar um opção vazia e ela irá executar o proximo caso até parar em um break
            //    case 3:
            //        Console.WriteLine("Opção 3");
            //        break;
            //    default:
            //        Console.WriteLine("Opção Padrão");
            //        break;
            // }

            #endregion

            #region Go To

            // inicio: // label, podemos usa-las em qualquer lugar do codigo e também no switch como ali em baixo
            // Console.Write("Escolha uma opção: ");
            // int op = int.Parse(Console.ReadLine());

            // int valor = 0;
            // switch(op)
            // {
            //    case 1:
            //        valor += 100;
            //        break;
            //    case 2:
            //        valor += 50;
            //        goto case 1; // vai para o caso 1 e vai atribuir +100 na variavel valor
            //    default:
            //        goto inicio;
            //        break;
            // }

            //Console.WriteLine("Valor final: " + valor);

            #endregion

            Console.Write("Pressione uma tecla: ");
            Console.ReadKey();
        }
    }
}
