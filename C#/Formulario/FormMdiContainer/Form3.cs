using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMdiContainer
{
    public partial class Form3 : Form
    {
        public Form3(Form parent)
        {
            MdiParent = parent;
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(MdiParent);
            f.Show();
            Close();
        }
    }
}
