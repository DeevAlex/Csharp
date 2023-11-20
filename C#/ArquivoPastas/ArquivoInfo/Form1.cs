using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquivoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            string pasta = @"C:\Users\Alex\Documents\GitHub\Csharp\C#\";
            string arquivo = @"texto.txt";

            FileInfo info = new FileInfo(pasta + arquivo);

            if (info.Exists) {
                lista.Items.Add("Nome: " + info.Name);
                lista.Items.Add("Endereço Completo: " + info.FullName);
                lista.Items.Add("Tamanho em bytes: " + info.Length);
                lista.Items.Add("Extenção: " + info.Extension);
                lista.Items.Add("Diretorio: " + info.Directory);
                lista.Items.Add("Data de Criação: " + info.CreationTime);
                lista.Items.Add("Existe: " + info.Exists);
                lista.Items.Add("Ultima data de Acesso: " + info.LastAccessTime);
            } else
            {
                lista.Items.Add("Arquivo não Existe!");
            }

        }

    }
}
