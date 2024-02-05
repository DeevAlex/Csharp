using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeclasComando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão 'Tecla X'";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão 'Tecla Enter'";
        }
    }
}
    