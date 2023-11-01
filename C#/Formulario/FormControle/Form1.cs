using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle
{
    public partial class Form1 : Form
    {
        Label label1;
        Button btn1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Adicionar Controles pelo Código Fonte

            // inserindo um label por tempo de execução
            label1 = new Label(); // criando uma label
            label1.Location = new Point(10, 10); // onde ele vai ficar
            label1.AutoSize = false; // ao aumentar o conteudo da label, ela também se aumenta, caso false tem que colocar o tamanho manualmente
            label1.Size = new Size(500, 100);
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black; // não precisa colocar, ele pega por herança
            label1.Font = new Font("Arial", 28, FontStyle.Regular, GraphicsUnit.Point);
            label1.Text = "Minha Label no Codigo";

            btn1 = new Button();

            btn1.Location = new Point(180, 282);
            btn1.Size = new Size(180, 60);
            btn1.Text = "Botão Codigo";
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);

            // para o intelisense montar o evento é só apertar Tab depois do += e colocar o nome do metodo
            btn1.Click += Btn1_Click; // adicionando evento, o += significa que pode ter mais de um evento
            btn1.MouseEnter += Btn1_MouseEnter;

            this.Controls.Add(label1); // adicionando um controle
            this.Controls.Add(btn1); // adicionando um controle

        }

        private void Btn1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "O mouse passou por cima do botão";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }
    }
}
