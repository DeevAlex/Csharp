using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {

        // Métodos Simples

        public void Cumprimentar()
        {
            Console.WriteLine("Olá seja bem vindo...");
        }

        // Métodos com parametros

        public void Soma(double num1, double num2)
        {
            Console.WriteLine("Resultado da soma de " + num1 + " + " + num2 + ": " + (num1 + num2));
        }

        public void Calculadora(double num1, double num2, char sinal) {
            switch(sinal)
            {
                case '+':
                    Console.WriteLine("Resultado da soma de " + num1 + " + " + num2 + ": " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Resultado da subtração de " + num1 + " - " + num2 + ": " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Resultado da multiplicação de " + num1 + " * " + num2 + ": " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Resultado da divisão de " + num1 + " / " + num2 + ": " + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("Resultado do modulo de " + num1 + " % " + num2 + ": " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Nenhum sinal correspondente!");
                    break;
            }

        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é: " + nome + " e tenho " + idade + " anos");
        }

        // Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor Final (Por Valor) é: " + valor);
        }

        // Passagem de parâmetros por referência
        public void AumentarRef(ref int valor) // aqui vai ser a referencia e não o valor, o valor da variavel que está sendo usada como referencia vai ser afetada
        {
            valor += 10;
            Console.WriteLine("Valor Final (Por Referência) é: " + valor);
        }

        // Métodos com retorno de valores

        public string MontaNome(string nome, string sobrenome) // quando você define um tipo de retorno no metodo, o precisa ter um return, que irá devolver o valor com o tipo
        {
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere) // o parametro não precisa ser do mesmo tipo do retorno da função
        {
            return caractere; // conversão implicita
        }

        public double ValorPi()
        {
            return 3.1415;
        }

    }
}
