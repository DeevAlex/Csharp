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
    public partial class Form2 : Form
    {
        public Form2(Form parent)
        {
            MdiParent = parent; // definindo quem é o MdiParent direto no construtor
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3(MdiParent);
            form3.Show();
            Close();

        }
    }
}
