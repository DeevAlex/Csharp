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

namespace Parte015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            #region Parte 1

            // Task parte1 = Task.Factory.StartNew(new Action(() => {
            //    Thread.Sleep(2000);
            //    progress.Invoke(new Action(() => { progress.Value += 25; })); // devemos fazer isso para que não trave nossa aplicação, pois está em uma thread diferente
            // }));

            // Task parte2 = parte1.ContinueWith((x) => {
            //    Thread.Sleep(2000);
            //    progress.Invoke(new Action(() => { progress.Value += 25; }));
            // });

            // Task parte3 = parte2.ContinueWith((x) => {
            //    Thread.Sleep(2000);
            //    progress.Invoke(new Action(() => { progress.Value += 25; }));
            // });

            // Task parte4 = parte3.ContinueWith((x) => {
            //    Thread.Sleep(2000);
            //    progress.Invoke(new Action(() => { progress.Value += 25; }));
            //    MessageBox.Show("A atualização foi realizada com sucesso!", "Atualização finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // });

            #endregion

            #region Parte 2

            // forma dinamica

            List<Task> tasks = new List<Task>();

            tasks.Add(new Task(new Action(() =>
            {

                Thread.Sleep(1000);
                progress.Invoke(new Action(() => {
                    progress.PerformStep(); // colocamos este metodo pois está numa List e não sabemos quantas tarefas serão realizadas, ele faz com que a cada tarefa avance um passo, 
                }));

            })));

            tasks.Add(new Task(new Action(() =>
            {

                Thread.Sleep(4000);
                progress.Invoke(new Action(() => {
                    progress.PerformStep(); // colocamos este metodo pois está numa List e não sabemos quantas tarefas serão realizadas, ele faz com que a cada tarefa avance um passo, 
                }));

            })));

            tasks.Add(new Task(new Action(() =>
            {

                Thread.Sleep(1000);
                progress.Invoke(new Action(() => {
                    progress.PerformStep(); // colocamos este metodo pois está numa List e não sabemos quantas tarefas serão realizadas, ele faz com que a cada tarefa avance um passo, 
                }));

            })));

            tasks.Add(new Task(new Action(() =>
            {

                Thread.Sleep(8000);
                progress.Invoke(new Action(() => {
                    progress.PerformStep(); // colocamos este metodo pois está numa List e não sabemos quantas tarefas serão realizadas, ele faz com que a cada tarefa avance um passo, 
                }));

            })));

            tasks.Add(new Task(new Action(() =>
            {

                Thread.Sleep(1000);
                progress.Invoke(new Action(() => {
                    progress.PerformStep(); // colocamos este metodo pois está numa List e não sabemos quantas tarefas serão realizadas, ele faz com que a cada tarefa avance um passo, 
                }));

            })));

            progress.Maximum = tasks.Count; // aqui estamos colocando a quantidade de tarefas a ser realizada como o preenchimento total da progressBar
            progress.Step = 1; // a cada tarefa realizada avance um passo

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Start(); // vai percorrer cada tarefa e vai executa-las
            }

            #endregion

        }
    }
}
