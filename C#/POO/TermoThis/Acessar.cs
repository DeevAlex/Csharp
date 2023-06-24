using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {

        string senha = "123abc";

        public bool Login(string senha)
        {
            return senha == this.senha; // o termo this, ele faz referencia a classe onde ele está sendo utilizado
        }

    }
}
