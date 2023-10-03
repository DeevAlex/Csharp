using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {

            // Messagebox normal - MessageBox.Show("Ola");
            // Messagebox com titulo - MessageBox.Show("Mensagem a ser impressa", "Titulo da Mensagem");
            // Messagebox definindo os botões - MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNo);
            // pegando o valor do botão clicado - DialogResult resultado = MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNoCancel);
            // DialogResult resultado = MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNoCancel);

            // if (resultado == DialogResult.Yes)
            // {
            //    lbResultado.Text = "Clicou em Sim";
            // } else if (resultado == DialogResult.Cancel)
            // {
            //    lbResultado.Text = "Clicou em Cancelar";
            // } else if (resultado != DialogResult.None) {
            //    lbResultado.Text = "Clicou em Não";
            // }

            // colocando um icone na mensagem - MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // define qual botão vai ficar marcado - MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {

            Random r = new Random(1); // o parametro aqui é o numero que vai ser utilizado para calcular o inicio do valor da sequencia numerica, utilizado para manipular os tipos de numeros aleatorios que serão gerados

            lbResultado.Text = r.Next(0, 100).ToString(); // no parametro definimos até qual numero ele vai gerar, minimo - numero definido

        }
    }
}
