using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal partial class Pessoa // uma classe que não é estatica pode conter métodos/atributos estaticos e não estaticos, porém, uma classe estatica só pode ter estaticos
    {

        public static int maioridade = 18; // servirá para todos 
        public string nome; // cada membro não estatico, terá uma caracteristica individual a partir da instancia
        public int idade;

    }
}
