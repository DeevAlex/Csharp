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

namespace DirInfo
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

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Alex\Documents\GitHub\Csharp\C#");

            lista.Items.Add("Endereço Completo: " + directoryInfo.FullName);
            lista.Items.Add("O diretorio Anterior: " + directoryInfo.Parent);
            lista.Items.Add("Nome: " + directoryInfo.Name);
            lista.Items.Add("Data de Criação: " + directoryInfo.CreationTime);
            lista.Items.Add("Existe: " + directoryInfo.Exists);
            lista.Items.Add("Raiz: " + directoryInfo.Root);
            lista.Items.Add("");
            lista.Items.Add("Diretorios dentro da pasta atual:");
            foreach (DirectoryInfo diretorios in directoryInfo.GetDirectories())
            {
                lista.Items.Add("   " + diretorios);
            }
            lista.Items.Add("");
            lista.Items.Add("Arquivos dentro da pasta atual:");
            foreach (FileInfo arquivo in directoryInfo.GetFiles())
            {
                lista.Items.Add("   " + arquivo);
            }

        }
    }
}
