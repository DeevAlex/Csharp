using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            // antes

            string[] nomes = new string[3];

            nomes[0] = "Julia";
            nomes[1] = "Juliana";
            nomes[2] = "Juliano";

            #region List

            // lista generica
            List<string> nomes2 = new List<string>();

            // adicionar
            nomes2.Add("Alex"); // 0 // o parametro aqui deve ser o mesmo do que está entre os <> da List ali em cima
            nomes2.Add("Marina"); // 1
            nomes2.Add("Johnson"); // 2
            nomes2.Add("Mike"); // 3

            // adicionar o valor da posição do array que a gente passa como parametro
            nomes2.AddRange(nomes);

            // remover
            nomes2.Remove("Mike");

            // para mostrar na listbox

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }

            #endregion


        }
    }
}
