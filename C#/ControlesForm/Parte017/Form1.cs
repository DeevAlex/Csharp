using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

            if (txt.Text == "Alex")
            {
                MessageBox.Show("Você digitou seu nome");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt.ZoomFactor > 1)
            {
                txt.ZoomFactor--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.ZoomFactor++;
        }
    }
}
