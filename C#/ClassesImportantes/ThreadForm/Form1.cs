using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {

        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Principal");

        }

        private void btnContador_Click(object sender, EventArgs e)
        {

            if (!t.IsAlive) // verifica se o t.Start() é true ou false
            {
                t.Start();
            }

        }

        private void Tarefa()
        {

            while (true)
            {

                // lbResultado.Text = DateTime.Now.Second.ToString(); // não podemos usar assim para atualizar o conteudo, pois foi contruido na thread principal, então vai travar a nossa aplicação
                // DefinirValorPropriedade(lbResultado, "Text", DateTime.Now.Second.ToString());

                lbResultado.Invoke(new Action(() => lbResultado.Text = DateTime.Now.Second.ToString())); // (forma resumida de atualizar o controle, passando um delegate anonimo e um metodo anonimo com uma assinatura lambda e a ação que seria executada) invoke é o metodo que permite atualizar o controle de uma thread difirente

            }

            // DefinirValorPropriedade(lbResultado, "Text", DateTime.Now.Second.ToString()); // mundando o texto da label para os segundos

        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired) // esse metodo retorna true caso esse controle necessitar que seja atualizado através do metodo invoke caso contrario retorna false
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade); // recursivo, estamos passando ele pois tem a mesma assinatura

                controle.Invoke(d, new object[] { controle, propriedade, valor }); // requer um invoke, e devemos passar um delegate e os parametros

            } else // no else é para um caso que o controle não necessita do invoke
            {
                Type t = controle.GetType(); // pegando o tipo do controle, controle é um botão por exemplo.
                PropertyInfo[] props = t.GetProperties(); // propriedades, Text do botão por exemplo

                foreach (PropertyInfo prop in props)
                {

                    if (prop.Name.ToUpper() == propriedade.ToUpper())
                    {
                        prop.SetValue(controle, valor, null); // colocando os valores que estão como parametros na propriedade do controle, como botão na propriedade Text
                    }

                }

            }
        }
    }
}
