using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {

        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        // o construtor é executado na instanciação, e é utilizado para dar valores padrões para os campos/variaveis
        public Pessoa()
        {
            nome = "Vazio";
            sobrenome = "Vazio";
            anoNascimento = 0;
            idade = 0;

        }

        // Sobrecarga de construtor (Overloading)
        public Pessoa(string nome, string sobrenome, int anoNascimento) // colocando/tirando outros parametros ou alterando o tipo deles corrige a sobrecarga
        {
            this.nome = nome; // faz refencia ao atributo do classe e não dos parametros
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        public Pessoa(string nome, string sobrenome) // colocando/tirando outros parametros ou alterando o tipo deles corrige a sobrecarga
        {
            this.nome = nome; // faz refencia ao atributo do classe e não dos parametros
            this.sobrenome = sobrenome;
            this.anoNascimento = 2008;
            idade = Idade();
        }

        private int Idade()
        {
            return 2023 - this.anoNascimento;
        }

    }
}
