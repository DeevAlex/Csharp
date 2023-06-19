using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos

            // MinhaClasse minhaClasse = new MinhaClasse();
            // MinhaClasse m2 = null; // atribuindo um objeto nulo

            // OutraClasse outraClasse = new OutraClasse();
            // OutraClasse outra2 = outraClasse; // vai ser atribuida a referencia do objeto outraClasse e não o valor

            #endregion

            #region Atributos

            // Pessoa p1 = new Pessoa();

            // p1.nome = "Alex";
            // p1.sobrenome = "...";
            // p1.idade = 19;
            // p1.maiorIdade = true;

            // Pessoa p2 = new Pessoa() { 
            //    nome = "Arthur", 
            //    sobrenome = "da Silva", 
            //    idade = 22, 
            //    maiorIdade = true,
            // };

            // // reatribuindo um valor na variavel
            // p1.nome = "Logan";

            // Console.WriteLine("Pessoa 1 -> " + "Nome: " + p1.nome + " " + p1.sobrenome + ", idade: " + p1.idade + ", maior de idade: " + p1.maiorIdade);
            // Console.WriteLine("Pessoa 2 -> " + "Nome: " + p2.nome + " " + p2.sobrenome + ", idade: " + p2.idade + ", maior de idade: " + p2.maiorIdade);

            #endregion

            #region Métodos Simples

            // Pessoa pessoa = new Pessoa();

            // pessoa.nome = "José";
            // pessoa.sobrenome = "Roblez";

            // pessoa.Comprimentar();

            #endregion

            Console.Write("Pressione uma tecla para finalizar: ");
            Console.ReadKey();

        }

        class MinhaClasse
        {
            
        }

    }
}
