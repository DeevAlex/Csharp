using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsync
{
    public class Exemplo
    {

        // Essa classe executa o codigo de forma sincrona, executa linha por linha e caso tenha uma tarefa longa de mais, travará o sistema (a thread principal) aguardando a tarefa ser concluida para executar o resto do codigo 

        // Método com retorno
        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        // Método com retorno void
        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa longa executada");
        }

        public void Task_LongaDuracao()
        {
            
            bool isAnoBissexto = Task_TResult();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um ano bissexto");
            Task_Void();

        }

    }
}
