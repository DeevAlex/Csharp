using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal sealed class Bicicleta : Veiculo // para herdar todos os membros da classe Veiculo, coloque : , sealed -> a classe que tiver esse operador não será herdada
    {

        // public string Cor { set; get; }
        // public string Marca { set; get; }

        // public void Acelerar()
        // {
        //    Console.WriteLine("Acelerou!");
        // }

        // public void Parar()
        // {
        //    Console.WriteLine("Parou!");
        // }

        public override void Acelerar() // esse override, significa que esse metodo que está como abstrato, na classe Veiculo, está sendo sobre-escrevido
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a Bicicleta!");
        }

        public void Pedalar()
        {
            Console.WriteLine("Pedalando!");
        }

    }
}
