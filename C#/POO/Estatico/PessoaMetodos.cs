using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    // não pode ter duas classes com mesmo nome no mesmo namespace
    internal partial class Pessoa // partial - indica que essa classe é parte da outra, em todas com mesmo nome, devemos colocar partial para retirar o erro
    {

        public void Apresentar()
        {
            Console.WriteLine("Olá eu sou, " + nome); // nos continuamos com o acesso aos membros da outra classe
        }

        public static int CalcularIdade(int anoNascimento)
        {
            // esse datetime.now.year pega o ano atual
            return DateTime.Now.Year - anoNascimento;
        }

        // as classes partial servem para ter um controle melhor e não deixar as classes muito extensa

    }
}
