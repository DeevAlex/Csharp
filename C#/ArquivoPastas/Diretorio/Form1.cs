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
using System.Xml.Linq;

namespace Diretorio
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

            string caminho = @"C:\Users\Alex\Documents\GitHub\Csharp\C#\";
            bool res = Directory.Exists(caminho + "Alex");

            // lista.Items.Add("Existe: " + res);

            // if (!res)
            // {
            //    Directory.CreateDirectory(caminho + "Alex");
            // } else
            // {
            //    lista.Items.Clear();
            //    lista.Items.Add("Já Existe");
            // }

            // if (!res)
            // {
            //    lista.Items.Clear();
            //    lista.Items.Add("Não Existe");
            // }
            // else
            // {
            //    lista.Items.Clear();
            //    lista.Items.Add("Diretorio Apagado!");
            //    Directory.Delete(caminho + "Alex");
            // }

            // if (!res)
            // {
            //    lista.Items.Clear();
            //    lista.Items.Add("Não Existe");
            // }
            // else
            // {
            //    lista.Items.Clear();
            //    lista.Items.Add("Diretorio Movido!");
            //    Directory.Move(caminho + "Alex", @"C:\Users\Alex\Downloads\" + "Movido");
            // }

            // string[] dirs = Directory.GetDirectories(caminho);

            // foreach (string diretorio in dirs)
            // {
            //    lista.Items.Add(diretorio);
            // }

            // string[] arquivos = Directory.GetFiles(caminho);

            // foreach (string arquivo in arquivos)
            // {
            //    lista.Items.Add(arquivo);
            // }

            // lista.Items.Add(Directory.GetDirectoryRoot(caminho));

            // string[] discos = Directory.GetLogicalDrives();

            // foreach (string disco in discos)
            // {
            //    lista.Items.Add(disco);
            // }

            // lista.Items.Add("Diretorio Pai:\n" + Directory.GetParent(caminho));

            lista.Items.Add("Diretorio Atual:\n" + Directory.GetCurrentDirectory()); // retorna o diretorio do Debug do projeto atual



        }
    }
}

// Metodos da classe Directory
// Directory.Exists();
// Directory.CreateDirectory();
// Directory.Delete();
// Directory.Move();
// Directory.GetDirectories();
// Directory.GetFiles();
// Directory.GetDirectoryRoot();
// Directory.GetLogicalDrives();
// Directory.GetParent();
// Directory.GetCurrentDirectory();

