using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {

        int x;
        int y;
        int largura;
        int altura;
        int num_linhas;
        int pagina;
        int num_paginas;

        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                largura = printDocument1.DefaultPageSettings.Bounds.Width;
                altura = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print(); // ele executa o metodo PrintPage do printDocument, caso não tenha uma impressora ele salva em pdf
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            #region Parte 1

            // string texto = "Trabalhando com impressão.";
            // Font fonte = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
            // Brush pincel = new SolidBrush(Color.Black);
            // Point ponto = new Point(100, 50);

            // // Desenhar o documento para ser impresso
            // e.Graphics.DrawString(texto, fonte, pincel, ponto); // ele é o desenhador
            // e.Graphics.DrawString("Alex", fonte, pincel, new Point(100, 150)); // ele é o desenhador
            // e.Graphics.FillRectangle(Brushes.Green, new Rectangle(100, 220, 400, 100));

            #endregion

            #region Parte 2

            // define a area da pagina
            // Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            // int x = printDocument1.DefaultPageSettings.Bounds.X;
            // int y = printDocument1.DefaultPageSettings.Bounds.Y;
            // int altura = printDocument1.DefaultPageSettings.Bounds.Height;
            // int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            // o +50 é a margem Esquerda/Direita
            // o +100 é a margem cima/baixo

            // string titulo = "Titulo da Página";
            // Font fonteTitulo = new Font("Verdana", 24, FontStyle.Regular | FontStyle.Underline, GraphicsUnit.Pixel);
            // Brush pincelTitulo = new SolidBrush(Color.Red);
            // Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
            // StringFormat formatoTitulo = new StringFormat();
            // formatoTitulo.Alignment = StringAlignment.Center;
            // formatoTitulo.LineAlignment = StringAlignment.Center;

            // string texto = "Trabalhando com impressão.";
            // Font fonte = new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Pixel);
            // Brush pincel = new SolidBrush(Color.Black);
            // Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);

            // // Desenhar o documento para ser impresso
            // e.Graphics.DrawString(titulo, fonteTitulo, pincelTitulo, areaTitulo, formatoTitulo); // ele é o desenhador
            // e.Graphics.DrawString(texto, fonte, pincel, areaTexto); // ele é o desenhador

            // e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTitulo);
            // e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

            #endregion

            #region Parte 3

            List<string> linhas = new List<string>()
             {
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "10. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "20. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "30. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "40. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "50. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "60. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "70. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "80. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "90. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "7. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "8. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "9. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "100. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
             };

            string titulo = "Titulo da Página";
            Font fonteTitulo = new Font("Verdana", 24, FontStyle.Regular | FontStyle.Underline, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Red);
            Rectangle areaTitulo = new Rectangle(x, y, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;


            // Desenhar o documento para ser impresso
            Font fonte = new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Point);
            Brush pince = new SolidBrush(Color.Black);



            while (num_linhas < linhas.Count)
            {

                if (num_linhas == 0)
                {
                    e.Graphics.DrawString(titulo, fonteTitulo, pincelTitulo, areaTitulo, formatoTitulo);
                    y += 150; // espaço entre o titulo e as linhas
                }

                e.Graphics.DrawString(linhas[num_linhas], fonte, pince, new Point(x, y));
                y += 30; // espaço entre as linhas
                num_linhas++;

                // esse if vai definir uma nova pagina ou não
                if (y >= altura - 50) // o -50 é para dar uma margem de 50 em baixo
                {
                    // mudar de pagina
                    y = 50;
                    e.HasMorePages = true;
                    num_paginas++;
                    break;
                }

            }

            #endregion

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printPreviewControl1.Document = printDocument1;

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

            if (pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }

        }

        private void btnProxima_Click(object sender, EventArgs e)
        {

            if (pagina < num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }

        }

        private void btnVisualizarPadrao_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

    }
}
