using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal static class CadastroUsuarios
    {

        private static Usuario[] usuarios =
        {
            new Usuario(){ Nome = "Alex", Senha = "J1234E56B" },
            new Usuario(){ Nome = "Juliana", Senha = "BA137496X" },
            new Usuario(){ Nome = "Roberto", Senha = "ACQ987213" }
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario u in usuarios)
            {
                if (u.Nome == nome && u.Senha == senha)
                {
                    UsuarioLogado = u;
                    return true;
                }
            }
            return false;
        }

    }
}
