using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {

        // Definição de um campo
        private string _nome;
        public string Sobrenome
        {
            // podemos fazer assim também
            get;
            set;
        } = "Vazio"; // define um valor padrão 

        private int _idade;

        // Definição de uma propriedade

        public string Nome
        {

            // pode ter getter ou setter ou os dois ao mesmo tempo

            get // definindo um getter - vai pegar o valor que está na variavel x
            {
                return _nome;
            }

            set // definindo um setter - vai colocar valor na variavel x
            {
                _nome = value;
            }
        }

        public int Idade
        {

            // pode ter getter ou setter ou os dois ao mesmo tempo

            get // definindo um getter - vai pegar o valor que está na variavel x
            {
                return _idade;
            }

            set // definindo um setter - vai colocar valor na variavel x
            {
                // podemos colocar regras no setter
                
                // value - é o valor que está sendo recebido
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior a 18 anos");
                } else
                {
                    _idade = value;
                }

            }
        }

        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }

    }
}
