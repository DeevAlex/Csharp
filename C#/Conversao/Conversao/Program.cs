using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversão Implicita

            // byte num1 = 100; // 8 bits, de 0 a 255
            // ushort num2; // 16 bits, 0 a 65.535

            // float num3 = 1250.45f;
            // double num4 = num3;

            // num3 = num1; // não há erro, pois cabe inteiro em uma variavel com ponto flutuante

            // num2 = num1; // Só podemos fazer uma conversão sem perca de dados para um tipo maior, caso menor irá ter perca de dados
            // num1 = num2; // aqui há um erro pois tem um limite muito inferior a da ushort que tem um limite muito grande e não cabe na variavel byte

            // char letra = 'A';
            // int numero = letra; // pois ele retorna um numero inteiro do caractere da tabela ASCII
            // int numero2 = 'B';

            #endregion

            #region Conversão Explicita

            // Pode haver perca de dados, então o C# obriga a colocar (tipo) <variavel>, para conseguir converter, caso a variavel tenha a mesma abrangencia de dados que a variavel que esta sendo convertida não haverá perca de dados, apenas se passar

            // ushort num1 = 3000;
            // byte num2 = (byte) num1;

            // float num3 = 2500.250f; // nesse caso o numero convertido perderá as casas decimais na conversão
            // int num4 = (int) num3;

            // int num5 = (int) 7050.123;

            // char letra = (char) 107; // ele vai converter esse numero para um caractere da tabela ASCII

            #endregion

            #region Metodo Parse

            // string txtNumero = "1984";

            // int numero = int.Parse(txtNumero); // convertendo um numero que está em uma string em int 32bits, não pode ter letra, apenas numeros

            // byte num1 = byte.Parse("75"); // forma literal

            // double num2 = double.Parse("125623,57"); // coloque ponto quando é atribuição e quando é forma literal use virgula

            // float num3 = float.Parse("457,75"); // na forma literal não precisa colocar <numero>f para representar que é do tipo float

            #endregion

            #region Classe Convert

            
            string texto = Convert.ToString(2540); // convertendo para o tipo do metodo
            double num1 = Convert.ToDouble(false);
            int num2 = Convert.ToInt32('C'); // nesse caso ele vai pegar o codigo do caractere
            // double num3 = Convert.ToDouble('C'); // nesse caso ele vai dar um erro nessa conversão

            #endregion

            Console.WriteLine(num2);
            Console.ReadKey();

        }
    }
}
