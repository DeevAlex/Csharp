using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            open.Filter = "Imagem png|*.png|Filme.mp4|*.mp4|Filmes e Fotos|*.png;*.mp4|Todos os Arquivos| *.*"; // "primeiro é a descrição | *.extensão" , define qual tipo de arquivo podemos abrir

            if (open.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = open.FileNames[0]; // mostra o endereço do arquivo
                foreach (string arquivos in open.FileNames)
                {
                    listBox1.Items.Add(arquivos);
                }
            }

        }
    }
}
