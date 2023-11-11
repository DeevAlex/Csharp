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

namespace Parte032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (!worker.IsBusy)
            {

                worker.RunWorkerAsync(); // executa as tarefas de forma assincrona

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (worker.WorkerSupportsCancellation) // se o worker pode ser cancelado
            {
                worker.CancelAsync(); // cancela o trabalho assincrono
            }

        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                
                if (worker.CancellationPending) // verifica se alguem apertou em cancelar
                {

                    e.Cancel = true; // cancenlando
                    break;

                } else
                {

                    Thread.Sleep(500);
                    worker.ReportProgress(i * 10); // informa o progresso em cada tarefa que terminar

                }

            }

        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            label1.Text = e.ProgressPercentage.ToString() + " %"; // colocando a porcentagem das tarefas concluidas na label
            progressBar1.Invoke(new Action(() => {
                progressBar1.Value = e.ProgressPercentage;
            }));

        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled)
            {

                label1.Text = "Cancelado";

            } else if (e.Error != null)
            {

                label1.Text = "Erro: " + e.Error.Message;

            } else {

                label1.Text = "Concluido";
                progressBar1.Invoke(new Action(() => {
                    progressBar1.Value = 100;
                }));

            }

        }
    }
}
