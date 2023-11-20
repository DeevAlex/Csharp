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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string pasta = @"C:\Users\Alex\Documents\GitHub\Csharp\C#\";
            string arquivo = @"texto.txt";
            string destino = @"C:\Users\Alex\Downloads\";

            string escreverFrase = "Teste de escrita em arquivos";

            bool res = File.Exists(pasta + arquivo);

            // label1.Text = res.ToString();

            // if (res)
            // {
            //    File.Delete(pasta + arquivo);
            //    label1.Text = "Arquivo foi deletado!";
            // }
            // else
            // {
            //    label1.Text = "Arquivo não existe!";
            // }


            // if (!res)
            // {
            //    File.Create(pasta + arquivo); // tem que tomar cuidado, pois ele sobreescreve o arquivo existente caso contenha algum conteudo nele, faça uma verificação como essa para resolver!
            //    label1.Text = "Arquivo criado!";
            // } else
            // {
            //    label1.Text = "Arquivo já existe!";
            // }

            // if (!res)
            // {
            //    label1.Text = "Arquivo não existe";
            // } else
            // {
            //    File.Copy(pasta + arquivo, pasta + "copia.txt", true); // esse terceiro parametro é a permissão de sobreescrita do arquivo copiado
            //    label1.Text = "Arquivo Copiado";
            // }

            // if (!res) {
            //    label1.Text = "Arquivo não Existe";
            // } else
            // {
            //    if (File.Exists(destino + arquivo))
            //    {
            //        label1.Text = "Arquivo já existe na pasta de destino";
            //        return;
            //    } else
            //    {
            //        File.Move(pasta + arquivo, destino + arquivo);
            //        label1.Text = "Arquivo foi movido para:\n" + destino + arquivo;
            //    }
            // }

            // if (res)
            // {
            //    File.WriteAllText(pasta + arquivo, escreverFrase, Encoding.UTF8); // sobreescreve o arquivo existente, faça uma verificação para evitar problemas
            //    label1.Text = "O conteudo do " + arquivo + ", foi alterado para:\n" + escreverFrase;
            // } else
            // {
            //    label1.Text = "O arquivo: " + arquivo + ", não existe!";
            // }

            // if (res)
            // {
            //    label1.Text = File.ReadAllText(pasta + arquivo, Encoding.UTF8); 
            // } else
            // {
            //    label1.Text = "Arquivo não existe!";
            // }

            // File.SetCreationTime(pasta + arquivo, DateTime.Now); // coloca a data de criação para x data
            label1.Text = "Data de criação do aqruivo '" + arquivo + "' foi em: " + File.GetCreationTime(pasta + arquivo); // pega a data de criação

        }


    }
}

// Metodos da Classe File:
// File.Exists();
// File.Delete();
// File.Create();
// File.Move();
// File.Copy();
// File.WriteAllText();
// File.ReadAllText();
