using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {

        // public, indica que ficarão visiveis em todos os lugares em que a classe for utilizada, tanto em herança quanto nos objetos criados a partir dessa classe
        // private, indica que são privados dessa classe, portanto só ficaram visiveis nessa classe, e não ficaram visiveis para herança
        // protected, são visiveis para classes que herdam, porém, os objetos que são instanciados não possuem acesso
        // internal, o membro que possuir esse modificar, ficará restrito a essa aplicação

        private string nome;
        public string sobrenome;

        private void Metodo1()
        {

        }

        public void Executar() { }

    }

    class Humano
    {
        protected string nome;
        private string sobrenome;
        internal int idade;
    }

    class Homem : Humano
    {

        public void Metodo()
        {
            nome = "";
        }

    }

}
