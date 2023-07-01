using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursiva
    {

        // sem recursividade
        public void Executar(string mensagem, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem + " " + (i + 1));
            }
        }

        // com recursividade

        public void ExecutarRecursivo(string mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem + " " + (n));
                ExecutarRecursivo(mensagem, n - 1); // caso não tenha uma estrutura de controle ele ficará se auto-executando
            }
        }

    }
}
