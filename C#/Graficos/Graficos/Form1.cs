using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {

        Dictionary<double, double> valores;
        int contadorX = 0;

        public Form1()
        {
            InitializeComponent();
            valores = new Dictionary<double, double>();
        }

        private void btnInserirValores_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(xValor.Text) ||  string.IsNullOrEmpty(yValor.Text))
            {
                MessageBox.Show("Os dois valores são obrigatórios");
                return;
            }

            if (valores.ContainsKey(double.Parse(xValor.Text)))
            {
                valores[double.Parse(xValor.Text)] = double.Parse(yValor.Text);
            } else
            {
                valores.Add(double.Parse(xValor.Text), double.Parse(yValor.Text));
            }


            // Fazendo uma consulta com LINQ para ordenar de forma crescente o grafico (isso fara com que a linha do grafico não vá para tras caso um valor menor for posto)
            // Poderiamos ordernar diretamente o Dictionary
             
            var items = from valor in valores orderby valor.Key ascending select valor;

            dataValores.Rows.Clear(); // limpar todas as linhas para reinserir com novos valores (refresh)

            // A series é a quantidade de linhas exibidas no grafico, os Points são as coordenadas (X e Y)
            grafico.Series[0].Points.Clear();

            foreach (var item in items)
            {
                dataValores.Rows.Add(item.Key, item.Value); // adicionando os valores que está no nosso dictionary no dataValores
                grafico.Series[0].Points.AddXY(item.Key, item.Value); // inserindo valores na serie que irão ir nas coordenadas que estão no nosso Dictionary (o X é o <variavel>.Key e o Y e o <variavel>.Value
            }

            grafico.Update(); // atualizando o grafico com os novos valores

            xValor.Text = "";
            yValor.Text = "";
            xValor.Focus();

        }

        private void dataValores_SelectionChanged(object sender, EventArgs e)
        {
            // Estamos pegando a linha selecionada e pegando o valor da primeira celula que é a X e transformando para texto e colocando no campo de texto
            xValor.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[0].Value.ToString();
            // Estamos pegando a linha selecionada e pegando o valor da segunda celula que é a Y e transformando para texto e colocando no campo de texto
            yValor.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            valores.Clear();
            grafico.Series[0].Points.Clear();
            dataValores.Rows.Clear();
            contadorX = 0;
            xValor.Text = "";
            yValor.Text = "";
            xValor.Focus();
        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Series[0].ChartType = (SeriesChartType)tipoGrafico.SelectedItem;
        }

        private void palletCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Palette = (ChartColorPalette) palletCor.SelectedItem;
        }

        private void grafico3D_CheckedChanged(object sender, EventArgs e)
        {
            // habilitando para o grafico ficar 3D
            grafico.ChartAreas[0].Area3DStyle.Enable3D = grafico3D.Checked;
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {

            // Esse metodo irá apenas ativar o timer

            timer.Enabled = !timer.Enabled; // caso habilitado, irá desabilitar e vice versa

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xValor.Focus();
            
            for (int i = 0; i < 35; i++) { 
                tipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)
            {
                palletCor.Items.Add((ChartColorPalette)i);
            }

        }

        private void xValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vericando se o caractere clicado é um digito, char.IsDigit(e.KeyChar) - verifica apenas numeros
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (xValor.Text.Contains((char)44) && e.KeyChar == (char)44)) // esse 8 é o numero do codigo da tecla do backspace, o 13 é do Enter e o 44 é da virgula, e a segunda verificação verifica se já tem uma virgula já no campo de texto
            {
                e.Handled = true; // para não ser inserido
            }
        }

        private void yValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (yValor.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            // a cada meio segundo ele vai fazer x acão

            if (grafico.Series[0].Points.Count > 10) { // para não espremer o grafico quando chegar a 10 coordenadas, dai sempre eliminará a primeira coordenada
                grafico.Series[0].Points.RemoveAt(0);
                grafico.Update();
            }

            // fazendo ser o maximo aleatorio possivel usando o DateTime.Now.Ticks, com um valor maximo que é 1000
            double y = (double)new Random((int)DateTime.Now.Ticks).Next(1000);

            grafico.Series[0].Points.AddXY(contadorX++, y); // o X será de 1 em 1 e o y será o numero aleatorio

            dataValores.Rows.Add(contadorX, y); // adicionando os valores na tabela

            dataValores.CurrentCell = dataValores.Rows[dataValores.Rows.Count - 1].Cells[0]; // isso levará a linha selecionada para o ultimo, dando o efeito de paginação

        }
    }
}
