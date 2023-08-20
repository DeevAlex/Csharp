using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse

            // int num;
            // bool res = int.TryParse("2004", out num); // vai tentar converter a string para numero e vai jogar o valor na variavel num
            // // caso não consiga converter ele vai atribuir zero na variavel de saida

            // if (res)
            // {
            //    labelResultado.Text = num.ToString();
            // }
            // else
            // {
            //    labelResultado.Text = "Erro na conversão";
            // } 

            #endregion

            #region Método ToString

            // double num = 120.5;

            // podemos colocar formatação da string colocando parametro dentro do ToString
            // esse metodo só muda a formatação, não o tipo da variavel
            // e caso coloque duas casas após a virgula ele só mostrará o que foi colocado, caso tenha mais ele ignorará o restante dos numeros após a virgula
            // labelResultado.Text = num.ToString("00000.00"); // para mudar as unidades
            // labelResultado.Text = num.ToString("#.00"); // para mudar apenas as casas decimais

            // int numero = 10;

            // caso a letra estiver em lowerCase ele mostra as letras Hexadecimal nesse formato, porém se estiver em upperCase ele mostrará nesse formato
            // labelResultado.Text =  numero.ToString("x<digitos que serão mostrados>"); // para mostrar o numero que está na variavel em formato Hexadecimal
            // labelResultado.Text =  numero.ToString("d<digitos que serão mostrados>"); // para mostrar o numero que está na variavel em formato decimal
            // labelResultado.Text = numero.ToString("C"); // para mostrar o numero que está na variavel em formato monetario
            // labelResultado.Text = Convert.ToString(numero, <base (Ex: base decimal, hexadecimal etc)>); // para mostrar o numero que está na variavel em formato x
            // labelResultado.Text = Convert.ToString(numero, 2); // converter para binario

            #endregion

            #region Classe Math

            // double pi = Math.PI;
            // double e = Math.E;
            // double seno = Math.Sin(3);
            // double conseno = Math.Sin(3);
            // double potencia = Math.Pow(2,5);
            // double raizQuadrada = Math.Sqrt(49);
            // double arredondarMaisProximo = Math.Round(158.75); 
            // double retornaApenasNumeroInteiro = Math.Truncate(32.57);
            // double arredondaParaBaixo = Math.Floor(55.6);
            //double arredondaParaCima = Math.Ceiling(55.4);

            // labelResultado.Text = pi.ToString("#.00");
            //labelResultado.Text = arredondaParaCima.ToString("#.00");

            #endregion

        }
    }
}
