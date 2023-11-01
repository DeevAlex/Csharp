using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // lista.Columns.Add(); // adicionar colunas através de codigo

            ListViewItem item1 = new ListViewItem("Alex");

            item1.SubItems.Add("11545478982");
            item1.SubItems.Add("alex@yahoo.com");

            ListViewItem item2 = new ListViewItem("Juliana");

            item2.SubItems.Add("114214598974");
            item2.SubItems.Add("juliana@yahoo.com");

            ListViewItem item3 = new ListViewItem("Danilo");

            item3.SubItems.Add("115214978978");
            item3.SubItems.Add("danilo@yahoo.com");

            ListViewItem item4 = new ListViewItem(new string[] { "Marina", "11954754678", "marina@yahoo.com" });

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // lista.Items.Clear();
            // lista.Items.Remove(lista.SelectedItems[0]); // lista.SelectedItems[0] são a quantidade de items selecionados, caso só tenha um, coloque 0
            lista.Items.RemoveAt(1);
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Item cliado: " + lista.SelectedItems[0].Text);

        }
    }
}
