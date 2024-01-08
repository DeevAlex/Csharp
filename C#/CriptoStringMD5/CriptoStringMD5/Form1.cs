using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoStringMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {

            CriptoMD5 mD5 = new CriptoMD5();

            txtSaida.Text = mD5.RetornarMD5(txtEntrada.Text);

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {

           string senhaNoBanco = "BB49F226BF2B2D4E592580BD0F0E14B8"; // 123234

           string senha = txtEntrada.Text;

            CriptoMD5 mD5 = new CriptoMD5();

            if (mD5.CompararMD5(senha, senhaNoBanco))
            {
                labelResultado.ForeColor = Color.Green;
                labelResultado.Text = "Iguais";
            } else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Não são Iguais";
            }


        }
        
    }
}
