using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // this.Text = "Alex";
            // this.Size = new Size(400, 200);
            // this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Alex" && this.textBox2.Text == "123abc")
            {
                this.label3.Visible = true;
                this.label3.ForeColor = Color.LightGreen;
                this.label3.Text = "ENTROU COM SUCESSO!";
            } else
            {
                this.label3.Visible = true;
                this.label3.ForeColor = Color.Red;
                this.label3.Text = "ACESSO NEGADO!";
            }

            if (this.checkBox1.Checked)
            {
                this.textBox1.Text = "Alex";
                this.textBox2.Text = "123abc";
            } else
            {
                this.textBox1.Text = "Preencha";
                this.textBox2.Text = "Preencha";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "Minha Aplicação";
            this.Text = textBox1.Text;
        }

        private void MeuMetodo(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
