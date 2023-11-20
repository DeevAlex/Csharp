using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerEscrever
{
    public partial class Form1 : Form
    {

        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscreverTxt_Click(object sender, EventArgs e)
        {

            string caminho = @"C:\Users\Alex\Desktop\Teste\arquivo.txt";
            StreamWriter streamWriter = new StreamWriter(caminho, true, Encoding.UTF8); // podemos passar como parametro booleano que faz com que sobreescreva o arquivo (Apaga tudo o que tinha) ou Adicione o conteudo ao arquivo sem perda de conteudo

            // true é o Append
            // false é a sobreescrita do arquivo

            // streamWriter.WriteLine(txtConteudo.Text);

            streamWriter.Write(txtConteudo.Text);

            // não é obrigatorio
            // streamWriter.Flush(); // limpa todos os buffers utilizados pelo escritor atual
            // streamWriter.Dispose(); // faz a mesma coisa

            streamWriter.Close();

            txtConteudo.Text = "";

            MessageBox.Show("Alteração Feita!");


        }

        private void btnLerTxt_Click(object sender, EventArgs e)
        {

            txtConteudo.Text = "";
            string caminho = @"C:\Users\Alex\Desktop\Teste\arquivo.txt";
            StreamReader streamReader = new StreamReader(caminho, true);

            // o true do parametro do streamReader é para detectar o encoding que é a codifição de caracteres a partir dos bytes

            // txtConteudo.Text = streamReader.ReadToEnd(); // lê o arquivo até o final
            // txtConteudo.Text = streamReader.ReadLine(); // lê apenas uma linha
            // txtConteudo.Text += streamReader.ReadLine(); // lê apenas uma linha e concatena
            // txtConteudo.Text += streamReader.ReadLine(); // lê apenas uma linha e concatena

            // string linha = streamReader.ReadLine();

            // while (linha != null)
            // {
            //    txtConteudo.Text += linha + "\n";
            //    linha = streamReader.ReadLine();
            // } 

            while(!streamReader.EndOfStream) { // esse end of stream conseguimos saber se chegou no final do arquivo

                // streamReader.Read() - retorna o codigo dos caracteres
                txtConteudo.Text += (char) streamReader.Read();

            }

            // sempre devemos fechar até mesmo no streamWriter
            streamReader.Close();

        }

        private void btnLerBinary_Click(object sender, EventArgs e)
        {

            txtConteudo.Text = "";
            txtConteudo.Text = "Arquivo foi lido!";
            string caminho = @"C:\Users\Alex\Desktop\Teste\arquivo.txt";
            string caminho2 = @"C:\Users\Alex\Documents\GitHub\Csharp\C#\JokenPo\JokenPo\bin\Debug\imagens\Papel.png"; 
            string caminho3 = @"C:\Users\Alex\Desktop\Teste\UMSNHDKBRDA.mp4"; // é superior a 2gb da erro, faça com um arquivo menor de 2gb!
            string caminho4 = @"E:\Filmes\BRLHOETRNODUMTSMLEMBR.mp4";
            BinaryReader binaryReader = new BinaryReader(File.OpenRead(caminho4), Encoding.Default);


            // while(binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            // {
            //    // podemos ler arquivos de texto, video, audio e imagem
            //    byte b = binaryReader.ReadByte();
            //    txtConteudo.Text += (char) b;
            // }

           // buffer = binaryReader.ReadBytes((int) binaryReader.BaseStream.Length);
            
            // foreach (byte b in buffer)
            // {
            //    txtConteudo.Text += (char) b;
            // }

            binaryReader.Close();

            // buffer = File.ReadAllBytes(caminho4); // nao precisaria criar o objeto binaryReader, pois fazem a leitura diretamente no arquivo

        }

        private void btnEscreverBinary_Click(object sender, EventArgs e)
        {

            txtConteudo.Text = "";
            txtConteudo.Text = "Arquivo Criado!";
            string caminho = @"C:\Users\Alex\Desktop\Teste\arquivoNovo.txt";
            string caminho2 = @"C:\Users\Alex\Documents\GitHub\Csharp\C#\JokenPo\JokenPo\bin\Debug\imagens\PapelNova.png";
            string caminho3 = @"C:\Users\Alex\Desktop\Teste\UMSNHDKBRDANovo.mp4";
            string caminho4 = @"E:\Filmes\BRLHOETRNODUMTSMLEMBRNovo.mp4";

            BinaryWriter writer = new BinaryWriter(File.OpenWrite(caminho4), Encoding.Default);

            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();

        }

    }
}
