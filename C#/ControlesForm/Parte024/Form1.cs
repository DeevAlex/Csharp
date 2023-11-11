using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("imagens/Empatar.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("imagens/Perder.png");
        }
    }
}
