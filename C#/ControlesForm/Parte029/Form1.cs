using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            statusLabel.Text = this.Size.Width + "x" + this.Size.Height;
            statusProgress.Value = 75;

        }

        private void zoom100ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Size = new Size(600, 400);

        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
     
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Size = new Size(this.Size.Width + 20, this.Size.Height + 20);

        }
    }
}
