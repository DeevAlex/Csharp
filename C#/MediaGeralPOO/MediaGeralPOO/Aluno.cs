using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Aluno
    {

        public string Nome { get; set; }
        private double[] _notas;

        public double Media {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas) {

            Nome = nome;
            _notas = new double[provas];

        }

        public void InserirNotas()
        {
            for(int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Digite a #" + (i + 1) + " nota: ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            double media = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }

    }
}
