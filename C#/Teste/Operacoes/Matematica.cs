using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{

    // para trasformar em .dll basta clicar no nome do namespace ali no 'Gerenciador de Soluções' com o lado direito do mouse e clicar em compilar
    // o .dll estará na pasta do namespace > bin > debug

    // Não precisa ter o mesmo nome do namespace
    public class Matematica // para fazer ser acessivel/visivel, SEMPRE coloque public 
    {

        public static double Valor1;
        public static double Valor2;

        public static double Somar()
        {
            return Valor1 + Valor2;
        }

        public static double Subtrair()
        {
            return Valor1 - Valor2;
        }

        public static double Multiplicar()
        {
            return Valor1 * Valor2;
        }

        public static double Dividir()
        {
            return Valor1 / Valor2;
        }

    }

}
