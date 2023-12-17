using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print(); // ele executa o metodo PrintPage do printDocument, caso não tenha uma impressora ele salva em pdf
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            #region Parte 1

            string texto = "Trabalhando com impressão.";
            Font fonte = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush pincel = new SolidBrush(Color.Black);
            Point ponto = new Point(100, 50);

            // Desenhar o documento para ser impresso
            e.Graphics.DrawString(texto, fonte, pincel, ponto); // ele é o desenhador

            #endregion

        }

    }
}
