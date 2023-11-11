using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFolder_Click(object sender, EventArgs e)
        {

            if (folderBrowser.ShowDialog() != DialogResult.Cancel) {
                lblFolder.Text = "Caminho da Pasta: " + folderBrowser.SelectedPath;
            }

        }
    }
}
