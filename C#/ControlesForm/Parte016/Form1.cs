using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            if (radio1.Checked)
            {
                this.BackColor = Color.Red;
            } else if (radio2.Checked)
            {
                this.BackColor = Color.Green;
            } else if (radio3.Checked) {
                this.BackColor = Color.Blue;
            }

        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

            if (radio1.Checked)
            {
                MessageBox.Show("Selecionado: Vermelha");
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked)
            {
                MessageBox.Show("Selecionado: Verde");
            }
        }
        
        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3.Checked)
            {
                MessageBox.Show("Selecionado: Azul");
            }
        }
    }
}
