using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf = "512.604.250-53"; // Substitua pelo CPF que você deseja verificar

            if (IsCpfValido(cpf))
            {
                Console.WriteLine("CPF válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }

            Console.WriteLine("Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }

        static bool IsCpfValido(string cpf)
        {
            // Remover caracteres não numéricos
            cpf = new string(cpf.ToCharArray().Where(char.IsDigit).ToArray());

            // Verificar se o CPF tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Calcular dígito verificador
            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (!ValidarDigito(cpf, multiplicadoresPrimeiroDigito, 9) ||
                !ValidarDigito(cpf, multiplicadoresSegundoDigito, 10))
            {
                return false;
            }

            return true;
        }

        static bool ValidarDigito(string cpf, int[] multiplicadores, int posicaoDigito)
        {
            int soma = 0;

            for (int i = 0; i < multiplicadores.Length; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplicadores[i];
            }

            int resto = soma % 11;
            int digitoVerificador = resto < 2 ? 0 : 11 - resto;

            return digitoVerificador == int.Parse(cpf[posicaoDigito].ToString());
        }
    }
}
