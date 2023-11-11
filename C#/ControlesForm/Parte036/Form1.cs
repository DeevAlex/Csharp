using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument1.Print();
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Graphics é para trabalhar com desenhos em C#
            // quando vamos imprimir, trabalhamos com desenhos

            Font fonte = new Font("Arial", 20, FontStyle.Regular);
            Brush pincel = new SolidBrush(Color.Black);
            e.Graphics.DrawString(txtPrint.Text, fonte, pincel, new PointF(20, 20));

        }

        private void button2_Click(object sender, EventArgs e)
        {

            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            
            if (pageSetupDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument1.Print();
            }

        }

    }
}
