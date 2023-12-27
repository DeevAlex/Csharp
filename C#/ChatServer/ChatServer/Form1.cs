using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {

        private delegate void AtualizaStatusCallback(string strMensagem);

        bool conectado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {

            if (conectado)
            {
                Application.Exit();
                return;
            }

            if (txtIP.Text == string.Empty)
            {
                MessageBox.Show("Informe um endereço IP.");
                txtIP.Focus();
                return;
            }

            try
            {

                // Analisa o endereco IP do servidor informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);
                int portaHost = (int) numPorta.Value;

                // cria uma nova instancia do objeto ChatServidor
                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                // inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                // mostra que nos iniciamos o atendimento para conexões
                listaLogs.Items.Add("Servidor ativo, aguardando usuarios conectarem-se");
                listaLogs.SetSelected(listaLogs.Items.Count - 1, true);

            }
            catch (Exception ex)
            {

                listaLogs.Items.Add("Erro de conexão: " + ex);
                listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
                return;

            }

            conectado = true;
            txtIP.Enabled = false;
            numPorta.Enabled = false;
            btnStartServer.ForeColor = Color.Red;
            btnStartServer.Text = "Sair";

        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {

            // Chama o metodo que atualiza o formulario
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });

        }

        private void AtualizaStatus(string strMensagem)
        {
            
            // Atualiza o logo com mensagem
            listaLogs.Items.Add(strMensagem);
            listaLogs.SetSelected(listaLogs.Items.Count - 1, true);

        }

    }
}
