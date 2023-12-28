using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operacoes;

namespace TesteDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // para importar a DLL, clique com o lado direito em 'referências' do projeto ali em 'Gerenciador de Soluções', dai clique em 'adicionar referência', clique em 'procurar' e procure sua DLL que você criou e clique em ok e pronto! (caso não esteja selecionada, clique no checkbox)

            // Para usar:

            // Operacoes.Matematica.Somar(); // Assim devemos colocar o namespace caso não tenha importado usando o 'using'

            Matematica.Valor1 = 100;
            Matematica.Valor2 = 5;


            label1.Text = Matematica.Somar().ToString(); // Assim sem precisar colocar o namespace
        }

    }
}
