using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkedList.Items.Add("Carro", true);
            checkedList.Items.Add("Moto");
            checkedList.Items.Add("Barco");
            checkedList.Items.Add("Avião");

            // int qtdItems = checkedList.Items.Count;

            // MessageBox.Show("Quantidade de items: " + qtdItems);

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            // checkedList.Items.Clear();

            // checkedList.Items.AddRange(new object[] { "Bike", "Mobilete", "Caminhão" });

            // MessageBox.Show("Contém? " + checkedList.Items.Contains("Avião"));

            // int indice = checkedList.SelectedIndex;

            // checkedList.Items.Remove("Moto");
            // checkedList.Items.RemoveAt(indice);

            // checkedList.Items.Insert(1, "Cavalo"); // insere na posição x

            // var itemsChecked = checkedList.CheckedItems; // armazena os valores que estiverem checados
            // var itemsSelected = checkedList.SelectedItems; // armazena o valor que estiver selecionado

            // foreach (var item in itemsChecked)
            // {
            //    MessageBox.Show(item.ToString());
            // }

            // foreach (var item in itemsSelected)
            // {
            //    MessageBox.Show(item.ToString());
            // }

        }

        private void checkedList_SelectedIndexChanged(object sender, EventArgs e)
        {

            // label1.Text = checkedList.SelectedIndices.ToString(); // mostra o indice do item selecionado
            // label1.Text = checkedList.SelectedItem.ToString(); // mostra o valor do item selecionado

        }
    }
}
