using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            // Etapas
            // 1º Criar uma folha em branco
            // 2º Criar um desenhador
            // 3º Utilizar o desenho ou imagem


        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {

            // Folha em branco

            Bitmap folha = new Bitmap(picture.Width, picture.Height);

            // Criar desenhador

            Graphics desenhador = Graphics.FromImage(folha);

            // Desenhar na folha

            desenhador.Clear(Color.White);

            #region Linhas

            // Brush pincel1 = new SolidBrush(Color.Red);


            // Pen lapis1 = new Pen(pincel1, 5); // definimos o lapis, colocamos a cor e a largura
            // Point ponto1 = new Point(100, 200); // começe o desenho em x posição
            // Point ponto2 = new Point(400, 100); // termine o desenho em x posição

            // Pen lapis2 = new Pen(Color.Black, 10); // definimos o lapis, colocamos a cor e a largura
            // Point ponto3 = new Point(0, 0); // começe o desenho em x posição
            // Point ponto4 = new Point(100, 200); // termine o desenho em x posição

            // desenhador.DrawLine(lapis1, ponto1, ponto2); // desenha uma linha de cada vez
            // desenhador.DrawLine(lapis2, ponto3, ponto4);

            // Point[] pontos = { 
            //    new Point(50, 50),
            //    new Point(250, 50),
            //    new Point(250, 150),
            //    new Point(100, 80),
            //    new Point(85, 140),
            // };

            // desenhador.DrawLines(lapis1, pontos); // desenha mais de uma linha de uma vez

            #endregion

            #region Retangulo

            // Pen lapis1 = new Pen(Color.Black, 5);
            // Pen lapis2 = new Pen(Color.Blue, 10);

            // Rectangle rect1 = new Rectangle(100, 50, 300, 200);
            // Rectangle rect2 = new Rectangle(50, 85, 120, 40);
            // Rectangle rect3 = new Rectangle(120, 20, 145, 100);
            // Rectangle rect4 = new Rectangle(75, 200, 250, 100);

            // Rectangle[] retangulos = {
            //    rect1 , rect2 , rect3 , rect4, new Rectangle(10, 30, 240, 85)
            // };

            // desenhador.DrawRectangle(lapis1, rect1);
            // desenhador.DrawRectangle(lapis2, 0, 0, 150, 150);

            // desenhador.DrawRectangles(lapis1, retangulos);

            // Brush pincel1 = new SolidBrush(Color.Red);
            // Brush pincel2 = new LinearGradientBrush(rect4, Color.Green, Color.Yellow, 45);
            // desenhador.FillRectangle(pincel2, rect4);
            // desenhador.FillRectangles(pincel1, retangulos);

            #endregion

            #region Circulos e Elipses

            // Pen lapis1 = new Pen(Color.Black, 5);
            // Rectangle rect1 = new Rectangle(150, 50, 200, 200); // para formar um circulo devemos colocar as mesmas dimensões tanto de largura quanto de altura
            // Brush pincel1 = new SolidBrush(Color.Yellow);

            // desenhador.DrawRectangle(lapis1, rect1);

            // desenhador.DrawEllipse(lapis1, rect1); // ele utiliza a area de um retangulo para desenhar uma elipse dentro da area

            // desenhador.FillEllipse(Brushes.Black, rect1); // coloque a classe e a cor sem a necessidade de criar um objeto, porém não podemos reutilizar em outros lugares, como uma variavel que tem o objeto Brush

            #endregion

            #region Poligonos

            //Pen lapis1 = new Pen(Color.Black, 5);
            //Brush lapis2 = new LinearGradientBrush(new Rectangle(100, 100, 200, 200), Color.Red, Color.Orange, 45);

            //Point[] pontos =
            //{ 

            //    new Point(100, 100),
            //    new Point(300, 200),
            //    new Point(250, 250),
            //    new Point(100, 200),
            // para adicionar mais lados, basta adicionar mais um ponto

            //};

            //desenhador.DrawPolygon(lapis1, pontos);
            // desenhador.FillPolygon(Brushes.Black, pontos);
            //desenhador.FillPolygon(lapis2, pontos);

            #endregion

            #region Curvas

            // Pen lapis1 = new Pen(Color.Black, 5);

            // Point[] pontos = {
            //         Y    X
            //    new Point(100, 50),
            //    new Point(300, 150),
            //    new Point(300, 100),
            //    new Point(500, 250),
            //    new Point(300, 300),
            // };

            // desenhador.DrawCurve(lapis1, pontos, 1.5f); // ele segue os pontos que estão no vetor de pontos e para sem interligar quando terminar
            // desenhador.DrawClosedCurve(lapis1, pontos, 1.5f, FillMode.Alternate); // ele une os pontos
            // desenhador.DrawClosedCurve(lapis1, pontos, 1.5f, FillMode.Winding); // ele une os pontos
            // desenhador.FillClosedCurve(Brushes.Red, pontos, FillMode.Winding, 1.5f);

            #endregion

            #region Arcos

            // Pen lapis1 = new Pen(Color.Black, 5);

            // Rectangle rect = new Rectangle(100, 100, 200, 200);

            // desenhador.DrawRectangle(lapis1, rect);

            // desenhador.DrawArc(lapis1, rect, 45f, 90f);

            #endregion

            #region Bazier

            // Pen lapis1 = new Pen(Color.Black, 5);

            //                   X    Y
            // Point p1 = new Point(50, 300);
            // Point p2 = new Point(200, 400);
            // Point p3 = new Point(300, 10);
            // Point p4 = new Point(500, 100);

            // desenhador.DrawBezier(lapis1, p1, p2, p3, p4);

            // Point[] pontos = {
            //    new Point(50, 300), // Inicio
            //    new Point(150, 350),
            //    new Point(300, 100),
            //    new Point(400, 150), // Meio
            //    new Point(500, 400),
            //    new Point(550, 10),
            //    new Point(600, 100), // Fim
            // };

            // desenhador.DrawBeziers(lapis1, pontos);

            #endregion

            #region Grafico Tipo Bolo

            // Pen lapis1 = new Pen(Color.Black, 5);

            // Rectangle rect1 = new Rectangle(50, 50, 400, 400);

            // desenhador.DrawRectangle(lapis1, rect1); // Contornando a area do retangulo

            // desenhador.DrawPie(lapis1, rect1, 0f, 90f); // Contorno com 90º graus
            // desenhador.DrawPie(lapis1, rect1, 0f, 180f); // Contorno com 180º graus
            // desenhador.DrawPie(lapis1, rect1, 0f, 360f); // Contorno com 360º graus

            // desenhador.FillPie(Brushes.Red, rect1, 270f, 90f); // Preenchendo com cor

            #endregion

            #region Grafico de Caminho

            // Pen lapis1 = new Pen(Color.Black, 5);
            // GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate); // ele preenche o primeiro e o proximo fica sem preenchimento
            // GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding); // ele preenche todos os desenhos

            // graphicsPath.AddEllipse(new RectangleF(10, 10, 100, 150));
            // graphicsPath.AddEllipse(new RectangleF(50, 10, 100, 150));
            // graphicsPath.AddRectangle(new RectangleF(120, 50, 150, 100));

            // desenhador.DrawPath(lapis1, graphicsPath); // Elemonta um caminho de graficos que ele vai montando
            // desenhador.FillPath(Brushes.Red, graphicsPath); 

            #endregion

            #region Strings

            // string texto = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            // Font fonte = new Font("Arial", 22, FontStyle.Regular, GraphicsUnit.Point);
            // Brush pincel = new SolidBrush(Color.Black); // com estilo normal
            // Brush pincel = new LinearGradientBrush(new Rectangle(0, 0, 400, 400), Color.Yellow, Color.Orange, 45); // Com estilo gradient
            // Point ponto = new Point(10, 20);
            // Rectangle rect = new Rectangle(10, 20, 550, 350);
            // StringFormat alinhamento = new StringFormat();

            // alinhamento.Alignment = StringAlignment.Center; // Alinhamento na horizontar, Near -> Esquerdo, Far -> Direito
            // alinhamento.LineAlignment = StringAlignment.Near; // Alinhamento na Vertical, Near -> Topo, Far -> Em Baixo
            // alinhamento.FormatFlags = StringFormatFlags.NoWrap; // NoWrap -< Não quebra a linha, Wrap -< Quebra
            // alinhamento.FormatFlags = StringFormatFlags.DirectionVertical; // Podemos colocar o texto na vertical ou na horizontal

            // desenhador.DrawString(texto, fonte, pincel, ponto);

            // desenhador.DrawRectangle(new Pen(Color.Red, 5), rect);
            // desenhador.DrawString("Titulo da Pagina", fonte, pincel, rect, alinhamento);
            // desenhador.DrawString(texto, fonte, pincel, new Rectangle(10, 80, 550, 300));

            #endregion

            #region Imagens

            Image imagem1 = Image.FromFile(@"C:\Users\Alex\Documents\GitHub\Csharp\C#\GDIPlus\GDIPlus\bin\Debug\imagens\rick-and-morty-minimalist-4k-wallpaper-uhdpaper.com-921@0@e.jpg");
            Rectangle origem1 = new Rectangle(0, 0, 75, 180);
            // Rectangle origem = new Rectangle(340, 140, imagem.Width, imagem.Height);
            Rectangle destino1 = new Rectangle(0, 0, picture.Width, picture.Height);
            // Rectangle destino = new Rectangle(100, 50, imagem.Width / 6, imagem.Height / 6);

            Image imagem2 = Image.FromFile(@"C:\Users\Alex\Documents\GitHub\Csharp\C#\GDIPlus\GDIPlus\bin\Debug\imagens\pxfuel.jpg");
            Rectangle origem2 = new Rectangle(40, 25, 150, 200);
            Rectangle destino2 = new Rectangle(170, 170, 150, 200);

            desenhador.DrawImage(imagem1, destino1, origem1, GraphicsUnit.Pixel);
            desenhador.DrawImage(imagem2, destino2, origem2, GraphicsUnit.Pixel);

            #endregion

            // utilizar em um pictureBox

            picture.BackgroundImage = folha;

            // salvar o desenho em um arquivo .jpg

            folha.Save(@"C:\Users\Alex\Documents\GitHub\Csharp\C#\desenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }

    }
}
