using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Classe Estática

            // Matematica m = new Matematica(); não é possivel instanciaar uma classe estaticas

            // para acessar os membros da classe matematica:
            //Matematica.taxa = 10;

            // classes estaticas - utilizarmos os métodos/atributos diretamente, se alterar o valor, irá mudar em outras classes também.
            // costumam ser usadas em configurações globais, em toda as aplicações, exemplo a cor do tema
            //int valor1 = Matematica.Adicionar(200); // +10 = 210
            //int valor2 = Matematica.Diminuir(200); // -10 = 190

            //Console.WriteLine("valor #1: " + valor1);
            //Console.WriteLine("valor #2: " + valor2);

            #endregion

            #region Membros Estáticos

            Pessoa.maioridade = 21; // só aparece os membros estaticos

            Pessoa p1 = new Pessoa();

            p1.nome = "Alex"; // só aparece os membros não-estaticos
            p1.idade = Pessoa.CalcularIdade(2004);

            Console.WriteLine(p1.nome); // membros não-estaticos só são acessados pela classe instanciada
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade); // membros estaticos só são acessados pela classe (sem ser instanciada)

            #endregion

            Console.Write("\nPressione uma tecla para finalizar: ");
            Console.ReadKey();

        }
    }
}
