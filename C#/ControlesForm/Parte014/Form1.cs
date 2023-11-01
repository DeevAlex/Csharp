using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // picture.BackgroundImage = Image.FromFile("images/Ganhar.png"); // definindo a imagem do pictureBox pelo caminho relativo
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //picture.Image = Image.FromFile("images/Empatar.png");
            picture.BackgroundImage = Image.FromFile("images/Empatar.png");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("images/Ganhar.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picture.BackgroundImage = Image.FromFile("images/Perder.png");
        }
    }
}
