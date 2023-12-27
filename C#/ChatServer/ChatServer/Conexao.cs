using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{

    // Esta classe trata as conexões , serão tantas quanto as instancias dos usuarios conectados 
    internal class Conexao
    {

        TcpClient tcpCliente;

        // A thread que irá enviar a informação para o cliente
        private Thread thrSender;

        private StreamReader srReceptor;
        private StreamWriter swEnviador;
        private string usuarioAtual;
        private string strResposta;

        // O construtor da classe que toma a conexão TCP
        public Conexao(TcpClient tcpCon)
        {
            tcpCliente = tcpCon;

            // A thread que aceita o cliente espera a mensagem
            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;

            // A thread chama o metodo AceitaCliente();

            thrSender.Start();

        }

        private void FechaConexao()
        {

            // Fecha os objetos abertos
            tcpCliente.Close();
            srReceptor.Close();
            swEnviador.Close();

        }

        // Ocorre quando um novo cliente é aceito
        public void AceitaCliente()
        {

            srReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());

            // lê as informaçoes da conta do cliente
            usuarioAtual = srReceptor.ReadLine();

            // temos uma resposta do cliente
            if (usuarioAtual != "")
            {

                // Armazena o nome do usuario na hash table
                if (Servidor.htUsuarios.Contains(usuarioAtual))
                {

                    // 0 -> significa não conectado
                    swEnviador.WriteLine("Codigo de erro: 0 | Este nome de usuario já existe!");
                    swEnviador.Flush();
                    FechaConexao();
                    return;

                } else if (usuarioAtual == "Administrator")
                {

                    // 0 -> significa não conectado
                    swEnviador.WriteLine("Codigo de erro: 0 | Este nome de usuario já está reservado!");
                    swEnviador.Flush();
                    FechaConexao();
                    return;

                } else
                {

                    // 1 -> conectou com sucesso
                    swEnviador.WriteLine("1");
                    swEnviador.Flush();

                    // inclui o usuario na hash table e inicia a escuta de suas mensagens
                    Servidor.IncluiUsuario(tcpCliente, usuarioAtual);

                }

            } else
            {
                FechaConexao();
                return;
            }

            try
            {

                // Continua aguardando por uma mensagem do usuario
                while ((strResposta = srReceptor.ReadLine()) != "")
                {

                    // se for invalido remove-o
                    if (strResposta == null)
                    {
                        Servidor.RemoveUsuario(tcpCliente);
                    }
                    else
                    {
                         
                        // Envia a mensagem para todos os outros usuarios
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);

                    }

                }

            }
            catch
            {

                // Se houver um problema com este usuario desconeta-o
                Servidor.RemoveUsuario(tcpCliente);

            }

        }

    }

}
