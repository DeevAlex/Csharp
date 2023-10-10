using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {



        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {

            Hide(); // esconde a form principal, ainda consome os recursos do computador

            FormSegunda segundoFormulario = new FormSegunda("Olá Mundo"); // passando no construtor

            // segundoFormulario.Mensagem = "Olá Mundo"; // enviando um dado para outra form, colocando direto na variavel

            // segundoFormulario.Show(); // mostra a segunda tela

            segundoFormulario.ShowDialog(); // ele abre a form sendo uma caixa de dialogo, e não vai dar acesso as outras forms da aplicação

            if (segundoFormulario.Mensagem != null)
            {
                lblPrincipal.Text = segundoFormulario.Mensagem;
            }

            Show(); // reexibir a form principal


        }

        private void btnSegundaThread_Click(object sender, EventArgs e)
        {

            Close(); // finaliza a aplicação
            Thread t = new Thread(() => Application.Run(new FormSegunda())); // criando uma thread e executando a segunda form
            t.Start();

        }

    }
}
