using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano // classe comum
    {

        // Podemos utilizar o operador sealed em classes, metodos e atributos, para que não sejam herdados em outras classes

        public virtual void Olhos() // esse virtual é semelhante ao abstract, o que difere é que no abstract não pode ter implementação na sua declaração, e a classe deve ser abstract para ter membros abstract
        // já o virtual pode ser sobreescrito igual o abstract, porém, pode ter uma implementação base
        {
            Console.WriteLine("Humano.Olhos"); // implementação base
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }

        // Ex: public abstract void Olhos();

    }

    class Pessoa : Humano
    {
        public sealed override void Olhos() // sobreescrevendo
        {
            Console.WriteLine("Pessoa.Olhos");
        }
        public override void Cabelos() // o sealed nesse caso não, vai fazer com que não tenha mais o poder de alterar o seu comportamento
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    {

        //public void Olhos() // sobreescrevendo
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}
        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }

    }

}
