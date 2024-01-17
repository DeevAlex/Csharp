using System.Threading.Tasks;
using System;

namespace ProjectAsync
{
    public class ExemploAsync
    {

        // Essa classe executa o codigo de forma assincrona, conforme que forem concluidas, será mostrada os resultados que forem concluidos

        // se temos algo com async sempre deve ter um await (ela espera por um retorno)

        // Método com retorno, nesse caso precisamos colocar Task<o tipo do retorno desse metodo, que no caso é um booleano>
        async Task<bool> Task_TResult_Async()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        // Método com retorno void (Task)
        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa longa executada");
        }

        public async Task Task_LongaDuracao()
        {

            bool isAnoBissexto = await Task_TResult_Async();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um ano bissexto");
            await Task_Void_Async();

        }

    }
}