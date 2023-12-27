using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {

        // trata o nome do usuario
        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        // Necessario para atualizar o formulario com mensagens da outra thread
        private delegate void AtualizaLogCallback(string strMensagem);

        // Necessario para definir o estado do formulario para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallback(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool conectado;
        

        public Form1()
        {

            // Na saida da aplicacao : desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            // se não esta conectando aguarda a conexão
            if (!conectado)
            {

                // Inicializa a conexao
                InicializaConexao();

            } else
            {

                // se esta conectado entao desconecta
                FecharConexao("Desconectando a pedido do usuario");

            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            EnviaMensagem();

        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Se pressionou a tecla Enter
            if (e.KeyChar == (char) 13)
            {
                EnviaMensagem();
            }

        }

        private void InicializaConexao()
        {

            try
            {

                // trata o endereco Ip informado em um objeto IPAdress
                enderecoIP = IPAddress.Parse(txtServidorIP.Text);
                //trata o numero da porta do host
                portaHost = (int) numPortaHost.Value;
                // inicia uma nova conexão TCP com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);

                // Ajuda a verificar se estamos conectados ou não
                conectado = true;

                // prepara o formulario
                NomeUsuario = txtUsuario.Text;

                // Desabilita e habilita os campos apropriados
                txtServidorIP.Enabled = false;
                numPortaHost.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                // Envia o nome do usuario ao servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txtUsuario.Text);
                stwEnviador.Flush();

                // inicia a thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                labelStatus.Invoke(new Action(() => {

                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = $"Conectado ao servidor de chat {enderecoIP}:{portaHost}";

                }));

            }
            catch (Exception ex)
            {

                labelStatus.Invoke(new Action(() => {

                    labelStatus.ForeColor = Color.Red;
                    labelStatus.Text = "Erro na conexão com o servidor: \n" + ex.Message;

                }));
                
            }

        }

        private void RecebeMensagens()
        {

            // recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            
            // Se o primeiro caracter da resposta é 1 a conexão foi feita com sucesso
            if (ConResposta[0] == '1')
            {

                // Atualiza o formulario para informar que esta conectado
                this.Invoke(new AtualizaLogCallback(this.AtualizaLog), new object[] { "Conectado com sucesso!" });

            } else
            {

                // se o primeiro caractere não for 1 a conexão falhou
                string motivo = "Não conectado: ";

                // Extrai o motivo da caractere resposta. O motivo começa no 3º caractere
                motivo += ConResposta.Substring(2, ConResposta.Length - 2);

                // Atualiza o formulario com o motivo da falha na conexão
                this.Invoke(new FechaConexaoCallback(this.FecharConexao), new object[] { motivo });

                // sai do metodo
                return;

            }

            // Enquanto estiver conectado lê as linhas que estão chegando do servidor
            while(conectado)
            {

                // Exibe as mensagens no textbox
                this.Invoke(new AtualizaLogCallback(this.AtualizaLog), new object[] { strReceptor.ReadLine() });

            }

        }

        private void AtualizaLog(string strMensagem)
        {

            // Anexa o texto ao final de cada linha
            txtLog.AppendText(strMensagem + "\r\n");

        }

        private void EnviaMensagem()
        {

            // envia a mensagem para o servidor
            if (txtMensagem.Lines.Length >= 1)
            {
                stwEnviador.WriteLine(txtMensagem.Text);
                stwEnviador.Flush();
                txtMensagem.Lines = null;
            }

            txtMensagem.Text = "";

        }

        private void FecharConexao(string Motivo)
        {

            // Fecha a conexão com o servidor
            // Mostra o motivo porque a conexão encerrou
            txtLog.AppendText(Motivo + "\r\n");

            // Habilita e desabilita os controles apropriados no formulario
            txtServidorIP.Enabled = true;
            numPortaHost.Enabled = true;
            txtUsuario.Enabled = true;
            txtMensagem.Enabled = true;
            btnConectar.ForeColor = Color.Black;
            btnConectar.Text = "Conectar";

            // Fecha os objetos
            conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();

            labelStatus.Invoke(new Action(() => {

                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = $"Desconectado do servidor de chat {enderecoIP}:{portaHost}";

            }));

        }

        // o tratador de evento para a saida da aplicacao
        private void OnApplicationExit(object sender, EventArgs e)
        {

            if (conectado)
            {

                // Fecha as conexões, streams, etc...
                conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                labelStatus.Invoke(new Action(() => {

                    labelStatus.ForeColor = Color.Green;
                    labelStatus.Text = $"Desconectado do servidor de chat {enderecoIP}:{portaHost}";

                }));

            }

        }

    }
}
