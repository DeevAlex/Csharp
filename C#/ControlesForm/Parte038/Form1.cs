using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString(txtPrint.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, 50, 50);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            printPreview.Document = printDoc;
            printPreview.ShowDialog();

        }

    }
}
