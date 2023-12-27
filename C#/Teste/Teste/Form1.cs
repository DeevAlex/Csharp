using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            Matematica.Valor1 = 100;
            Matematica.Valor2 = 2;

            listaResultado.Items.Clear();
            listaResultado.Items.Add("Soma de " + Matematica.Valor1 + " + " + Matematica.Valor2 + ": " + Matematica.Somar());
            listaResultado.Items.Add("Subtracao de " + Matematica.Valor1 + " - " + Matematica.Valor2 + ": " + Matematica.Subtrair());
            listaResultado.Items.Add("Multiplicação de " + Matematica.Valor1 + " x " + Matematica.Valor2 + ": " + Matematica.Multiplicar());
            listaResultado.Items.Add("Divisão de " + Matematica.Valor1 + " ÷ " + Matematica.Valor2 + ": " + Matematica.Dividir());

        }
    }
}
