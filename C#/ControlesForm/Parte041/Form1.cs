using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (font.ShowDialog() != DialogResult.Cancel)
            {
                label1.Font = font.Font;
                label1.ForeColor = font.Color;
            }

        }

        private void font_Apply(object sender, EventArgs e)
        {

            label1.Font = font.Font;
            label1.ForeColor = font.Color;

        }
    }
}
