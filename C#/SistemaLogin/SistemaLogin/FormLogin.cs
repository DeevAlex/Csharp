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
    public partial class FormLogin : Form
    {

        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if (CadastroUsuarios.Login(txtUsuario.Text, txtSenha.Text))
            {
                this.Close();
            } else
            {
                MessageBox.Show("Acesso Negado!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Cancelar = true;
            this.Close();

        }
    }
}
