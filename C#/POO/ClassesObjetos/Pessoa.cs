using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {

        // atributos da classe Pessoa
        public string nome;
        public string sobrenome;
        public int idade;
        public bool maiorIdade;

        // metodo simples sem retorno
        public void Comprimentar()
        {
            Console.WriteLine("Olá, eu sou " + nome + " " + sobrenome);
        }


    }
}
