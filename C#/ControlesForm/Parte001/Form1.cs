using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao curso de C#");
        }

        private void lblTitulo_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.Yellow;
        }

        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.DarkRed;
        }
    }
}
