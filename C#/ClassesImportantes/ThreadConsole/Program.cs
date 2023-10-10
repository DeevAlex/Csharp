using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // devemos importar essa classe para trablhar com o Thread 

namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tarefa(); // antes sem usar o thread 

            // Thread t = new Thread(Tarefa); // podemos fazer assim ou assim:
            Thread t = new Thread(new ThreadStart(Tarefa)); // delegate (thread segundaria)

            t.IsBackground = true; // essa propriedade faz com que quando a thread principal acabe suas tarefas, ele Interrompe a thread segundaria ainda que ela não tenha finalizado
            t.Start(); // para começar essa tarefa separado da Thread principal (vai rodar em simultâneo com a tarefa principal) e sempre teremos resultados diferentes dependendo da velocidade que cada thread está sendo executado
            t.Join(); // o join funciona como se ele Juntasse as tarefas da nossa thread na thread que está chamando-a (ele bloquear a primeira thread até que a segunda tenha terminado e quando terminar ai começa a primeira thread)

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(500); // gera uma pausa de x tempo (milisegundo - 1000ms é 1s)
            }

            Console.Write("Finalize o programa, clicando em uma tecla: ");
            Console.ReadKey(); // o readkey faz com que não Interrompa a tarefa segundaria porque a primeira tarefa ainda está esperando uma tecla ser clicada então visualmente não se altera, porém se remover-mos ele finaliza antes de terminar a segunda tarefa

        }

        static void Tarefa()
        {

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Tarefa Executada");
                Thread.Sleep(1000);

            }

        }

    }
}
