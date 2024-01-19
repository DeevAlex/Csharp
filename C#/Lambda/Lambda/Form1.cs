using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            // Expressão lambda que tem uma expressão como corpo:
            // (input - parameters) => expression

            // Instrução lambda que tem um bloco de instrução como corpo:
            // () => { < sequence - of - statements > | Sequencia de instruções | }

            // Delegate do tipo Func<Entrada, Saida>, faz as funcoes do metodo quadrado
            // Func<int, int> square = quadrado;
            // Func<int, int> square = x => x * x;

            // label1.Text = "O resultado é " + square(5);

            // Mostra a expresão que foi utilizada, Ex.: x => (x + x)
            // Expression<Func<int, int>> ex = x => x + x;

            // label1.Text = "O resultado é " + ex;

            // int[] n = { 2, 3, 4, 5 };

            // var squaredNumbers = n.Select(x => x * x);
            // label1.Text = string.Join(" ", squaredNumbers);

            // Action<string> comprimentar = nome =>
            // {
            //    string comprimentando = $"Olá {nome}";
            //    label1.Text = comprimentando;
            // };

            // comprimentar("{UM_NOME}");

            // Action line = () => Console.WriteLine();

            // Console.WriteLine("Palavras");
            // line();
            // Console.WriteLine("Aleatorias");

            // Func<Entrada, Entrada, Retorno>
            Func<int, int, bool> testForEquality = (x, y) => x == y;

            label1.Text = testForEquality(5, 5).ToString();

        }

        // Caso não reaproveite o metodo novamente o melhor é fazer uma expressão lambda
        int quadrado(int x)
        {
            return x * x;
        }

    }
}
