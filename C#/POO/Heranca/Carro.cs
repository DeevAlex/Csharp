using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {

        // public string Cor { set; get; }
        // public string Marca { set; get; }
        public int VelocidadeMaxima { set; get; }

        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o Carro!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o Carro!");
        }

        // public void Acelerar()
        // {
        //    Console.WriteLine("Acelerou!");
        // }

        // public void Parar()
        // {
        //    Console.WriteLine("Parou!");
        // }

    }
}
