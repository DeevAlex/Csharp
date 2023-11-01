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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // MdiContainer - é uma form onde pode receber outras forms dentro de seu corpo , como se fosse um contentor de forms (Deve mudar uma propriedade da form que queremos que seja um container a propriedade é isMdiContainer)

            Form2 form2 = new Form2(this); // passando essa classe como MdiContainer Parent no construtor da Form2

            // form2.MdiParent = this; // devemos colocar essa form como MdiParent antes de abrir a form2

            form2.Show();

        }


    }
}
