using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Média Geral dos Alunos"; // esse titulo vai ser atribuido ao console

            Console.Write("Digite a quantidade de alunos: ");
            int nAlunos = int.Parse(Console.ReadLine());
            Aluno[] alunos = new Aluno[nAlunos];

            for(int i = 0; i < alunos.Length; i++) {
                Console.Clear();

                Console.Write("Aluno #" + (i + 1) + ", Informe o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + ", Informe a quantidade de provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira a nota do aluno, " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno a in alunos)
            {
                Console.WriteLine("Aluno: " + a.Nome);
                Console.WriteLine("Média: " + a.Media + "\n");

                mediaGeral += a.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Média Geral dos Alunos: " + resultadoFinal);

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
