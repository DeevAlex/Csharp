using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            while(CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false; // não deixa que o formulario fique invisivel
                f.ShowDialog();

                if (FormLogin.Cancelar)
                {
                    Application.Exit(); // ela sai da aplicação em geral
                    return;
                }

            }

            labelBoasVindas.Text = "Bem Vindo(a) \n" + CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true;
        }
    }
}
