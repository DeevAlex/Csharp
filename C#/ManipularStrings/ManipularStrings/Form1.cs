using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            #region Contains / ToString

            //string texto = "Este tipo de variável é alfanumérica.";

            //if (texto.Contains("tipo"))
            //{
            //    label1.Text = "Contém";
            //}
            //else
            //{
            //    label1.Text = "Não contém";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = num.ToString();
            //label1.Text = res.ToString();

            #endregion

            #region ToUpper / ToLower

            //string nome = "Pablo";

            //nome = nome.ToUpper();

            //label1.Text = nome.ToUpper(); //tudo maiúsculo

            //label1.Text = nome.ToLower(); //tudo minúsculo

            #endregion

            #region IndexOf / LastIndexOf

            //string nome = "Pablo Ribeiro";

            //int indice = nome.IndexOf('o');

            //int indice = nome.IndexOf("blo");

            //int indice = nome.IndexOf('o', 5);

            //int indice = nome.IndexOf('o', 5, 4);

            //label1.Text = $"Indice: {indice}";

            //label1.Text = nome.IndexOf('o').ToString();

            //int indice = nome.LastIndexOf('o');

            //label1.Text = $"Indice: {indice}";

            #endregion

            #region Insert / Replace

            //string nome = "Pablo";

            //string nomeFinal = nome.Insert(5, " Rodrigo");

            //string nomeFinal = nome.Replace('o',  'i');

            //string nomeFinal = nome.Replace("Pablo", "Rodrigo");

            //label1.Text = nomeFinal;

            #endregion

            #region Length - SubString

            //string nome = "Alex de Matos";

            // a propriedade Length, mostra a quantidade de letras em uma string
            //label1.Text = "O nome: " + nome + ", contém: " + nome.Length.ToString() + " letras";

            //for(int i = 0; i < nome.Length; i++) {

            //    label1.Text += nome[i] + "\n";

            //}

            // a proriedade subString, consegue pegar parte da string, só definir o inicio e até x indice
            //string parte = nome.Substring(nome.LastIndexOf(" "), 6);

            //label1.Text = parte;

            #endregion

            #region Split

            //string nomes = "Alex Ramon Arthur_Marina-Gloria Flavio";

            //char[] separador = { ' ', '-', '_' };

            //string[] resultado = nomes.Split(separador, StringSplitOptions.None);

            //foreach (var item in resultado)
            //{
            //    label1.Text += item + "\n";
            //}

            #endregion

            #region StartsWith - EndsWith

            //string nome = "Alex";

            //bool positivo = nome.StartsWith("Al", StringComparison.OrdinalIgnoreCase);
            //bool positivo = nome.EndsWith("Al", StringComparison.OrdinalIgnoreCase);

            //if (positivo)
            //{

            //    label1.Text = "Positivo";

            //} else
            //{
            //    label1.Text = "Negativo";
            //}

            #endregion

            #region Trim - TrimStart - TrimEnd

            //string mensagem = "     _-      Olá Alex  5 _ -   ";

            //char[] c = { ' ', '-', '_', '5' };

            //label1.Text = ">" + mensagem.Trim() + "<"; // remove todos os espaços, do inicio e do fim
            //label1.Text = ">" + mensagem.TrimStart() + "<"; // remove todos os espaços, do inicio
            //label1.Text = ">" + mensagem.TrimEnd(c) + "<"; // remove todos os caracteres que estao no array c, do fim

            #endregion

            #region CompareTo - Equals

            //string nome = "Lucas";
            //string nome2 = "Gabriel";

            //if (nome.Equals("AlEx", StringComparison.OrdinalIgnoreCase))
            //{

            //    label1.Text = "Positivo";

            //} else
            //{

            //    label1.Text = "Negativo";

            //}

            // o CompareTo, originalmente é usado para classificar a string, ele vai verificar se uma string vem antes, se ela segue ou se está na mesma posição em ordem alfabetica da outra string que esta sendo passada como parametro
            // 0, pois está na mesma ordem alfabetica
            // -1, vem depois na ordem alfabetica
            // 1, vem antes na ordem alfabetica
            //label1.Text = nome.CompareTo(nome).ToString();

            #endregion

            #region Format

            //decimal valor = 19.95m;
            //int temp = 32;

            // o que estiver na variavel vai ser colocado no {(decimais) <posição do variavel>:N<quatidade de numero decimais que serão mostrados>, (mostra o formato de moeda) <posição do variavel>:C<quatidade de numero decimais que serão mostrados>}
            //string saida = String.Format("O valor do produto é: {0:C2} e a temperatura está {1}ºC", valor, temp);

            // pega a data e a hora os formata, (pega a data formatada 00/00/0000) - {0:d}, (pega data completa, dia da semana, dia, mes e ano) - {0:D}, (pega a hora:minutos) - {0:t} e (pega a hora:minutos:segundos) - {0:T} 
            //string saida = String.Format("Hoje é: {0:D} e são {0:T}", DateTime.Now);

            // podemos usar sem o String.Format, é so colocar o $ na frente da string, Ex: $"<txt>";
            //string saida = $"O valor do produto é: {valor:C2} e a temperatura está {temp}ºC";

            //string saida = $"Data: {DateTime.Now:d} e hora {DateTime.Now:t}";

            //label1.Text = saida;

            #endregion

        }
    }
}
