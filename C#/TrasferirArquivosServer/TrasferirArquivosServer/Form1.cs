using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrasferirArquivosServer
{

    // Realizar tarefas multihread para que não dê um problema de travar a nossa interface grafica

    public partial class Form1 : Form
    {

        Task tarefa; // responsavel para tratar com o servidor em multithread

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtPasta.Text = FTServer.PastaRecepcaoArquivos; // atribuindo ao LinkLabel o endereço da pasta onde será guardado os arquivos
            FTServer.ListaMensagem = listaLogs; // quando as mensagens forem geradas lá na classe aparecerá aqui também na nossa form

        }

        private void btnEstabelecerConexao_Click(object sender, EventArgs e)
        {

            int porta = (int) txtPorta.Value; // pegando a porta digitada
            string endIP = txtEnderecoIP.Text; // pegando o IP digitado

            // trabalhando com a conexão
            try
            {

                FTServer.EnderecoIP = endIP;
                FTServer.portaHost = porta;

                tarefa = Task.Factory.StartNew(() => {

                    FTServer.IniciarServidor(); // Inicia o servidor em uma Task separada para não causar travamentos na nossa interface grafica

                });

            } catch (Exception ex) {

                // atualizar a listaLogs em outra thread provavelmente, e não causar travamentos
                listaLogs.Invoke(new Action(() => { 
                
                    listaLogs.Items.Clear();
                    listaLogs.Items.Add("Erro ao conectar: " + ex.Message);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true); // seleciona e scrolla a listaLogs até o fim

                }));

            }

        }

        private void btnPararServidor_Click(object sender, EventArgs e)
        {

            try
            {

                // ele da um restart na nossa aplicação voltando do zero, automaticamente vai matar todas as threads que estiverem utilizadas do servidor para matar o serviço em segundo plano
                Application.Restart(); 

            } catch (Exception ex)
            {

                // atualizar a listaLogs em outra thread provavelmente, e não causar travamentos
                listaLogs.Invoke(new Action(() => {

                    listaLogs.Items.Clear();
                    listaLogs.Items.Add("Erro: " + ex.Message);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true); // seleciona e scrolla a listaLogs até o fim

                }));

            }

        }

        private void txtPasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            // se não cancelou
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {

                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\"; // atribuindo o caminho selecionado nesta variavel
                txtPasta.Text = FTServer.PastaRecepcaoArquivos; // mostra a pasta que foi definida

            }


        }

    }
}
