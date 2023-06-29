using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal abstract class Veiculo // para definir que essa classe será abstrata, e não poderá ser instanciada
    {

        public string Cor { set; get; }
        public string Marca { set; get; }

        public abstract void Acelerar(); // para obrigar a classe que estiver tendo relação com essa classe abstrata deverá implementar esse metodo

        public abstract void Parar();

    }
}
