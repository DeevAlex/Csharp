using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;

            if (nome == "")
            {
                MessageBox.Show("Adicione um nome no campo de texto!");
                return;
            }

            lista.Items.Add(nome);

            txtNome.Text = "";
            txtNome.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            object item = lista.SelectedItem;
            lista.Items.Remove(item);
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            lista.Items.RemoveAt(indice);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nome = lista.SelectedItem.ToString();
            txtNome.Text = nome;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int qtdItems = lista.Items.Count;
            MessageBox.Show("Quantidade de items na lista: " + qtdItems);
        }
    }
}
