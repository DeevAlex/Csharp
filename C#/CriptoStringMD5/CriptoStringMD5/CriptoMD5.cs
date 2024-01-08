using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CriptoStringMD5
{
    internal class CriptoMD5
    {

        // retorna uma hash já no formato apropriado para o usuario utilizar
        public string RetornarMD5(string senha)
        {
            // using anonimo, para garatir que todas as instancias dentro desse using sejam finalizadas ao fechar ele
            using(MD5 md5hash = MD5.Create()) // o create cria uma instancia com valores padrões do tipo MD5
            {

                return RetornarHash(md5hash, senha);

            }


        }

        public bool CompararMD5(string senhaDigitada, string senhaNoBD)
        {

            string senha = RetornarMD5(senhaDigitada);

            if (VerificarHash(senha, senhaNoBD))
            {
                return true;
            } else
            {
                return false;
            }

        }

        // criptografa
        private string RetornarHash(MD5 mD5Hash, string input)
        {

            byte[] data = mD5Hash.ComputeHash(Encoding.UTF8.GetBytes(input)); // vai obter um array de bytes a partir da string de entrada

            StringBuilder stringBuilder = new StringBuilder(); // constroi a string final

            // a cada passagem do for vai pegar uma letra e vai transformar em hexadecimal e vai adicionando no nosso stringBuilder
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("X2")); // Hexadecimal com letras maiusculas
            }

            return stringBuilder.ToString();
        }

        // Algoritmo de comparação das senhas
        private bool VerificarHash(string input, string hash)
        {

            StringComparer comparar = StringComparer.OrdinalIgnoreCase; // é um objeto para comparar strings e ele ignora a case sensitive

            if (comparar.Compare(input, hash) == 0) // metodo de comparar, caso 0 é igual e -1 menor que a segunda e 1 a primeira e menor que a segunda
            {
                return true;
            } else
            {
                return false;
            }

        }


    }

}
