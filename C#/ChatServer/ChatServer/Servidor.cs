using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{

    // Este delegate é necessario para especificar os parametros que estamos passando com o nosso evento
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

    internal class Servidor
    {

        // Estas hash tables vão armazenar os usuarios e as conexões (acessando/consultado por usuario)
        public static Hashtable htUsuarios = new Hashtable(30); // 30 usuarios é o limite definido
        public static Hashtable htConexoes = new Hashtable(30);

        // armazena o endereço IP passado
        private IPAddress enderecoIP;

        private int portaHost;

        private TcpClient tcpCliente;

        // O evento e o seu argumento irá notificar o formulario quando um usuario se conecta, desconecta, envia uma mensagem, etc
        public static event StatusChangedEventHandler StatusChanged;

        private static StatusChangedEventArgs e;

        // O construtor define o endereco IP para aquele retornado pela instaciação do objeto
        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
            portaHost = porta;
        }

        // A thread que irá tratar o escutador de conexões
        private Thread thrListener;

        // O objeto TCP object que escuta as conexões
        private TcpListener tlsCliente;

        // Irá dizer ao laço while para manter a monitoração das conexões
        bool ServRodando = false;

        // Inclui o usuario nas tabelas hash
        public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername)
        {

            // Primeiro inclui o nome e ã conexão associada para ambas as hash tables
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUsername);

            // informa a nova conexão para todos os usuarios e para o formulario do servidor
            EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou");

        }

        // Remove os usuarios das tabelas (hash tables)
        public static void RemoveUsuario(TcpClient tcpUsuario)
        {

            // se o usuario existir
            if (htConexoes[tcpUsuario] != null)
            {

                // Primeiro mostra a informação e informa os outros usuarios sobre a conexão
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + " saiu");

                // Remove o usuario da hash table
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);

            }

        }

        // Este evento é chamado quando queremos disparar o evento StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {

            StatusChangedEventHandler statusHandler = StatusChanged;

            if (statusHandler != null)
            {

                // Invoca o delegate
                statusHandler(null, e);

            }

        }

        // Envia mensagem administrativas
        public static void EnviaMensagemAdmin(string mensagem)
        {

            StreamWriter swSenderSender;

            // Exibe primeiro na aplicação
            e = new StatusChangedEventArgs(mensagem);
            OnStatusChanged(e);

            // Cria um array de clientes TCPs do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

            // copia os objetos TcpClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            // percorre a lista de clientes TCP
            for (int i = 0; i < tcpClientes.Length; i++)
            {

                // Tenta enviar uma mensagem para cada cliente
                try
                {

                    // se a mensagem estiver em branco ou a conexão for nula sai
                    if (mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    // Envia a mensagem para o usuario atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine($"{mensagem} - {DateTime.Now.DayOfWeek} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
                    swSenderSender.Flush(); // libera recursos
                    swSenderSender = null; // para não guardar os recursos do usuario

                }
                catch 
                {

                    // se houver um problema ou o usuari não existe, então remove-o

                    RemoveUsuario(tcpClientes[i]);

                }

            }

        }

        // Envia mensagens de um usuario para todos os outros
        public static void EnviaMensagem(string origem, string mensagem)
        {
            StreamWriter swSenderSender;

            // Primeiro exibe a mensagem na aplicação
            e = new StatusChangedEventArgs($"{origem}: {mensagem}");
            OnStatusChanged(e);

            // cria um array de clientes TCPs do tamanho do numero de clientes existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

            // copia os objetos TcpClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            // percorre a lista de clientes TCP
            for(int i = 0; i < tcpClientes.Length; i++)
            {

                // Tenta enviar uma mensagem para cada cliente
                try
                {

                    // se a mensagem estiver em branco ou a conexão for nula sai
                    if (mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }

                    // Envia a mensagem para o usuario atual no laço
                    swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSenderSender.WriteLine($"{origem}: {mensagem}");
                    swSenderSender.WriteLine($"{(DateTime.Now.Hour)}:{(DateTime.Now.Minute)}:{(DateTime.Now.Second)}");
                    swSenderSender.Flush(); // libera recursos
                    swSenderSender = null; // para não guardar os recursos do usuario

                }
                catch
                {

                    // se houver um problema ou o usuari não existe, então remove-o

                    RemoveUsuario(tcpClientes[i]);

                }

            }

        }

        public void IniciaAtendimento()
        {

            try
            {

                // Pega o IP
                IPAddress ipaLocal = enderecoIP;
                int portaLocal = portaHost;

                // Cria um objeto TCP listener usando o IP do servidor e porta definidas
                tlsCliente = new TcpListener(ipaLocal, portaLocal);

                // inicia o TCP listener e escuta as conexões
                tlsCliente.Start();

                // o laço while verifica se o servidor esta rodando ante de checar as conexões
                ServRodando = true;

                // incia uma nova thread que hospeda o listener
                thrListener = new Thread(MantemAtendimento);
                thrListener.IsBackground = true; // quando finalizarmos a nossa aplicação ele vai matar os processos da thread, porque se não vai ficar rodando em segundo plano até desligar o computador

                thrListener.Start();

            }
            catch (Exception ex)
            {
                
            }

        }

        private void MantemAtendimento()
        {

            // Enquanto o servidor estiver rodando
            while(ServRodando)
            {

                // Aceita uma conexão pendente
                tcpCliente = tlsCliente.AcceptTcpClient();

                // cria uma nova instancia da conexão
                Conexao newConnection = new Conexao(tcpCliente);

            }

        }

    }

}
