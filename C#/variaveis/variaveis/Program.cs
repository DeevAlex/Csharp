using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis
{
    internal class Program
    {

        enum Notas
        {
            Minimo,
            Media = 20, // assim atribuimos valores para elas, se não atribuir o proximo do setado ele vai seguir a ordem dos valores, e tem que ser inteiros
            Maxima // aqui seria o nome do membro da minha enumeração, e ele funciona com um sistema de indexação começando com 0 e assim em diante
        }

        struct Pessoa
        {
            public string nome; // devemos definir os modificadores de acesso
            public int idade;
            public double altura;
        }

        static void Main(string[] args) {

            #region Numericas Integrais

            // Integral assinado - suportam numeros negativos

            // sbyte num1 = 10; // 8 bits, de -128 a 127
            // short num2 = 20; // 16 bits, -32.768 a 32767 
            // int num3 = 30; // 32 bits, -2.147.483.648 a -2.147.483.647 
            // long num4 = 40L; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            // Integral sem sinal - não suportam numeros negativos

            // byte num5 = 10; // 8 bits, intervalo de 0 a 255
            // ushort num6 = 20; // 16 bits, de 0 a 65.535
            // uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            // ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            #endregion

            #region Numeros Reais

            // Reais

            // nesse float precisa colocar: float <nome da variavel> = <valor>f, para que funcione
            // float real1 = 100.5f; // 32 bits, de 1,5 * 10-45 a 3,4 * 1038, precisão de 7 digitos => Sufixo f, Ex: 10.65f   
            // double real2 = 500.775; // 64 bits, de 5,0 * 10-324 a 1,7 * 10308, precisão de 15 digitos => Sufixo d (opcional), Ex: 10.65d
            // decimal real3 = 752538.450M; // 128 bits, intervalo de pelo menos -7,9 * 10-28 a 7,9 * 1028, com precisão de pelo menos 28 digitos => Sufixo m, Ex: 10.5m

            #endregion

            #region Caractere

            // Caractere

            // codigo de caractere: '\u0062', consulte a tabela ASCII para saber esses codigos
            // char letra = '\u0062';
            // char escape = '\\'; 
            // char literal = 'A';

            #endregion

            #region Boolean

            // Boolean

            // bool verificar = true;

            #endregion

            #region String

            // para ignorar o caractere de escape de uma string é so colocar um @ na frente, Ex: @"Olá Mundo \n Nome: <nome>"
            // string texto = "Olá Mundo";
            // string mensagem = null;

            #endregion

            #region Tipo Implicito Var

            // não podemos reatribuir um valor de um tipo diferente usando var

            // var texto = "Olá Mundo";
            // var numero = 540;
            // var condicional = false;
            // var caractere = '\u0062';

            #endregion

            #region Object

            // nesse tipo de variavel pode atribuir qualquer valor, pois essa variavel é base dos outros tipos

            // object obj = null;
            // obj = 150;
            // obj = "Alex";

            #endregion

            #region Constantes

            // const double pi = 3.1415; // devemos atribuir os valores já na criação pois não podemos alterar o valor ao decorrer do codigo
            // const string nome = "Alex";

            #endregion

            #region Enumeração

            // Notas notasAlunos = Notas.Minimo;

            #endregion

            #region Structs

            /*
            Pessoa p1 = new Pessoa();

            p1.nome = "Alex";
            p1.idade = 19;
            p1.altura = 1.68;
            */

            /*
            Pessoa p2 = new Pessoa()
             {
                nome = "Jonas",
                idade = 18,
                altura = 1.74,
            }
            */

            // reatribuindo
            // p1.nome = "Lucas";

            #endregion

            Console.WriteLine();
            Console.WriteLine("\nPressione uma Tecla");
            Console.ReadKey();

        }
    }
}
