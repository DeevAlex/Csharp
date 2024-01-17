using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsync
{

    public partial class Form1 : Form
    {

        public static ListBox lstRes;

        public Form1()
        {
            InitializeComponent();
            lstRes = listaResultado;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            listaResultado.Items.Add("Evento do botão foi iniciado : clique aqui");

            Exemplo obj = new Exemplo();

            obj.Task_LongaDuracao();

            lstRes.Items.Add("Evento do botão foi concluido");

        }

        private async void btnExecutarAsync_Click(object sender, EventArgs e)
        {

            listaResultado.Items.Add("Evento do botão foi iniciado : clique aqui");

            ExemploAsync obj = new ExemploAsync();

            await obj.Task_LongaDuracao();

            listaResultado.Items.Add("Evento do botão foi concluido");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            listaResultado.Items.Clear();

        }

    }
}
