using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // executa uma tarefa em um intervalo de tempo

            Random r = new Random(DateTime.Now.Millisecond);

            label1.Text = r.Next(1000).ToString();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void btnParar_Click(object sender, EventArgs e)
        {

            timer1.Stop();

        }
    }
}
