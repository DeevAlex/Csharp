using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Caminhonete : Carro // Herança Multipla pois Carro está herdando de veiculo e Caminhonete Herdando de Carro e Veiculo
    {

        public bool CabineExtendida { get; set; }

    }
}
