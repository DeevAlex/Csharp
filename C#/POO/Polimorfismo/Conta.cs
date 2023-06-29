using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class CaixaEletronico : IConta
    {

        // a interface está intimamente ligada ao polimorfismo, a interface é uma especie de classe completamente abstrata
        // ao implementar uma interface, define um "contrato", você DEVE implementar todos os membros que estiverem nessa interface
        public string Usuario {
            get
            {
                return Usuario;
            }
            set
            {

            }
        }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
            
        }

        // podemos adicionar mais membros, porém não podemos retirar os membros que estão na interface
        public void SolicitarEmprestimo()
        {

        }
    }

    // por padrão começamos o nome da classe com I, não é uma regra mas para diferenciar de uma classe comum, pois na sua implementação é bem semelhante a uma classe
    interface IConta
    {
        // não precisamos colocar um modificador de acesso aqui pois todos os membros serão public por padrão
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
    } 
}
