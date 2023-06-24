using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {

        delegate void Operacao(double num1, double num2); // aqui tem que ser a mesma quantidade de parametro e mesmo tipo do retorno

        static void Main(string[] args)
        {
            // Delegate -> é um tipo de dado criado por nós, para armazenar referencias de metodos que tem o mesmo formato que ele foi declarado, com mesmo tipo de retorno e mesmo tipo de assinatura

            Matematica m = new Matematica();

            Operacao conta = null; // é um valor de referencia então pode ser null

            // adicionando

            conta += m.Somar; // colocando a refencia desse metodo somanar na variavel conta
            conta += m.Multiplicar;
            conta += m.Subtrair;
            conta += m.Multiplicar; // ele executa duas vezes se já tiver atribuido anteriormente, a 1ª e a 2ª
            conta += m.Dividir; // agora ele tem a referencia de todas as operações

            conta(25, 5);

            Console.WriteLine("");

            // subtraindo

            conta -= m.Dividir;
            conta -= m.Subtrair;

            conta(5, 5); // agora ele se comportar como se fosse o m.Somar, e vai realizar o calculo e vai mostrar

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
