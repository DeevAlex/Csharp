using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuApp
{
    public partial class Form1 : Form
    {

        // Para compilar para o modo de finalização do projeto, basta alterar de Debug (no lado esquerdo do botão de iniciar a aplicação) para Release e clicar em Build ou Rebuild no 'Gerenciador de Soluções' e clicando em cima da sua aplicação com o lado direito
        // Caso o nosso projeto tenha um banco de dados, uma DLL, pasta com imagens devemos colocar junto na hora de fazer o instalador pois são as dependencias dele

        // Para fazer um instalador:
        // baixe o Inno Setup: 'https://jrsoftware.org/isdl.php'
        // siga os passos desses videos:
        // 'https://www.youtube.com/watch?v=XPJx-ZpEem8' esse é para fazer um instalador profissional e instalar o banco de dados junto
        // 'https://www.youtube.com/watch?v=x45wNLpq1pk' esse é apenas para fazer um instalador profissional

        // No meu caso eu tive que desligar a segurança do windows porque ele ficava removendo o instalador

        public Form1()
        {
            InitializeComponent();
        }

    }
}
