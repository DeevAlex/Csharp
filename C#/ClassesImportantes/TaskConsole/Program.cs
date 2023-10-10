using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task parte 1 

            // parecido com o thread, Quem executa primeiro, aparece primeiro. (pode ser usado simultâneo

            // Task t1 = new Task(Tarefa);

            // t1.Start();

            // Task t2 = Task.Run(Tarefa);

            // Task.Run(Tarefa);

            // Task.Factory.StartNew(Tarefa);

            // Task.Run(() => {

            //    for (int i = 0; i < 10; i++)
            //    {

            //        Console.WriteLine("Tarefa Anônima");

            //    }

            // }); // passando um metodo anonimo

            // for (int i = 0; i < 10; i++)
            // {

            //    Console.WriteLine("Tarefa Principal");

            // }

            #endregion

            #region Task parte 2

            //Task[] tarefas = new Task[<tamanho>];
            //Task[] tarefas = { // quem finalizar primeiro, será executado primeiro
            //    Task.Factory.StartNew(() => { // startnew ele cria e já executa, ao invés de criar e colocar o start 
            //        Console.WriteLine("Tarefa #1");
            //    }),
            //    Task.Factory.StartNew(() => {
            //        Console.WriteLine("Tarefa #2");
            //    }),
            //    Task.Factory.StartNew(() => {
            //        Console.WriteLine("Tarefa #3");
            //    }),
            //};

            //Task t1 = Task.Run(() => { // executa quando for chamado
            //    Console.WriteLine("Comando #1");
            //});
            //Task t2 = Task.Run(() => { // executa quando for chamado
            //    Console.WriteLine("Comando #2");
            //});
            //Task t3 = Task.Run(() => { // executa quando for chamado
            //    Console.WriteLine("Comando #3");
            //});

            //Task.WaitAll(t1, t2, t3); // método statico que espera todas as tarefas serem finalizadas para executar os outros codigos

            //Console.WriteLine("Principal"); // ele vai executar primeiro, não vai esperar as tasks ali em cima, também tem a ordem de finalizar primeiro, se finalizar primeiro aparecerá primeiro


            #endregion

            #region Task parte 3

            // task com retorno

            // Task<int> tarefa1 = Task.Factory.StartNew(() => {

            //    return Dobro(5);

            // });


            //Console.WriteLine(tarefa1.Result); // mostra o resultado do return

            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {

                return new Random().Next(10); // retorna um numero entre 0 e 9

            });

            Task<int> tarefa2 = tarefa1.ContinueWith((retorno) => // ele continua apartir do termino da tarefa anterior
            {

                return Dobro(retorno.Result); // o num ali do parametro é o retorno da função anterior

            });

            Task<string> tarefa3 = tarefa2.ContinueWith((retorno) =>
            {

                return "Valor final: " + retorno.Result;

            });

            Console.WriteLine(tarefa3.Result);

            #endregion

            Console.Write("Pressione uma tecla para finalizar a tarefa: ");
            Console.ReadKey();

        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static private void Tarefa() // quando programando em console precisa colocar os metodos static
        {

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Tarefa do Task");

            }

        }
    }
}
