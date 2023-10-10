using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {

            // Messagebox normal - MessageBox.Show("Ola");
            // Messagebox com titulo - MessageBox.Show("Mensagem a ser impressa", "Titulo da Mensagem");
            // Messagebox definindo os botões - MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNo);
            // pegando o valor do botão clicado - DialogResult resultado = MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNoCancel);
            // DialogResult resultado = MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNoCancel);

            // if (resultado == DialogResult.Yes)
            // {
            //    lbResultado.Text = "Clicou em Sim";
            // } else if (resultado == DialogResult.Cancel)
            // {
            //    lbResultado.Text = "Clicou em Cancelar";
            // } else if (resultado != DialogResult.None) {
            //    lbResultado.Text = "Clicou em Não";
            // }

            // colocando um icone na mensagem - MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // define qual botão vai ficar marcado - MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {

            Random r = new Random(DateTime.Now.Millisecond); // o parametro aqui é o numero que vai ser utilizado para calcular o inicio do valor da sequencia numerica, utilizado para manipular os tipos de numeros aleatorios que serão gerados

            int valor1 = r.Next(100000); // gera somente inteiros
            double valor2 = r.NextDouble() * 140; // gera somente os decimais

            lbResultado.Text = "Numero: " + valor2; // no parametro definimos até qual numero ele vai gerar, minimo - numero definido

        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {

            // ajuda a trabalhar com intervalos de tempo    

            TimeSpan hora = TimeSpan.FromMinutes(90.5); // formata para 00:00:00 minutos
            TimeSpan dia = TimeSpan.FromDays(7.25); // formata para 00.00:00:00 dias
            TimeSpan ticks = TimeSpan.FromTicks(1000000); // formata para 00.00:00:00 dias, menor intervalo de tempo (100 nanosegundos)

            // TimeSpan.TicksPerMillisecond - para ver quantos ticks tem em x tempo

            TimeSpan inicio = new TimeSpan(1, 0, 0); // podemos passar um intervalo de tempo no construtor - Output: 5:30:30

            TimeSpan fim = new TimeSpan(3, 30, 0);

            //TimeSpan intervalo = fim - inicio;
            //TimeSpan intervalo = fim + inicio;

            //TimeSpan intervalo = inicio.Add(fim); // ele não vai alterar, apenas vai retornar, adiciona mais tempo
            TimeSpan intervalo = fim.Subtract(inicio); // ele não vai alterar, apenas vai retornar, subtrai mais tempo


            lbResultado.Text = intervalo.ToString();

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {

            //lbResultado.Text = DateTime.Today.ToString(); // tempo de hoje - formato: 00/00/0000 - 00:00:00
            //lbResultado.Text = DateTime.Now.ToString(); // tempo atual - formato: 00/00/0000 - 00:00:00
            //lbResultado.Text = DateTime.DaysInMonth(2023, 2).ToString(); // retorna quantos dias teve no ano x
            //lbResultado.Text = DateTime.IsLeapYear(2023).ToString(); // retorna se o ano x é bissexto
            //lbResultado.Text = DateTime.Now.ToLongDateString(); // retorna o dia, o dia do calendario, e o mês. Ex: terça-feira, 3 de outubro de 2023 .
            //lbResultado.Text = DateTime.Now.ToShortDateString(); // retorna o dia/mes/ano
            //lbResultado.Text = DateTime.Now.ToLongTimeString(); // retorna a hora hora:minuto:segundo
            //lbResultado.Text = DateTime.Now.ToShortTimeString(); // retorna a hora hora:minuto
            //lbResultado.Text = DateTime.Now.ToUniversalTime().ToString(); // retorna o formato universal UTC 
            //lbResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // retorna o tempo do jeito que a gente formata no parametro

            DateTime data = new DateTime(2004, 03, 03); // podemos passar parametros no construtor

            // data.AddYears(1); // adição de anos

            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);

            // data.Add(tempo);
            // data.DayOfWeek; // retorna o dia da semana
            // data.DayOfYear // retorna em que dia do ano estamos, Ex: 63 (informa quantos dias se passaram desde o começo do ano)

            lbResultado.Text = data.DayOfYear.ToString();


        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            // ForeColor - é a cor das letras
            // backColor - é a cor de fundo

            Color cor1 = Color.FromArgb(100, amarelo); // conseguimos modificar as cores em modo ARGB colocando a cor
            Color argb = Color.FromArgb(100, 0, 0, 255); // conseguimos modificar as cores em modo ARGB colocando o codigo da cor
            Color rgb = Color.FromArgb(0, 0, 255); // conseguimos modificar as cores em modo RGB colocando o codigo da cor
            Color cor2 = Color.FromKnownColor(KnownColor.Control); // cores conhecidas (São as cores do sistema
            Color cor3 = Color.FromName("DarkRed"); // colocando o nome das cores (Deve ser o mesmo que aparece no Color.<COR>

            lbResultado.BackColor = cor3;
            lbResultado.ForeColor = Color.AliceBlue;

            Color cor4 = lbResultado.BackColor;

            btnColor.ForeColor = cor4;

        }

        private void btnFont_Click(object sender, EventArgs e)
        {

            Font letra1 = new Font("Arial", 24, FontStyle.Regular | FontStyle.Bold, GraphicsUnit.Pixel); // colocando |, podemos ter bold e regular combinados
            Font letra2 = new Font(FontFamily.GenericMonospace, 36, FontStyle.Bold, GraphicsUnit.Pixel); // graphicsunit é a unidade de medida 
            Font letra3 = new Font("Helvetica, Arial, sans-serif", 24, FontStyle.Regular | FontStyle.Bold, GraphicsUnit.Pixel); // caso não encontre uma das fontes colocadas, tentará usar a que encontrar

            lbResultado.Text = "Bem vindo ao C#, Trabalhando com a classe Font";

            lbResultado.Font = letra2;

        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {

            // Environment = Ambiente;

            // ajuda a trabalhar/interagir com o sistema

            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // pega o caminho da pasta x

            // Environment.CurrentDirectory = "C:\\"; // podemos alterar pois é um getter/setter, e devemos colocar \\ pois uma só é caractere de escape

            string caminho2 = Environment.CurrentDirectory; // retorna o caminho do diretório onde está executavel

            // Environment.NewLine; // o newLine faz o mesmo que \n

            string varAmb = Environment.GetEnvironmentVariable("Path"); // pega os caminhos que estão na variavel de ambiente x

            string[] discos = Environment.GetLogicalDrives(); // retorna as unidades dos discos

            // lbResultado.Text = "";

            // foreach (string disco in discos)
            // {
            //    lbResultado.Text += disco + "\n";
            // }

            string user = Environment.UserName; // retorna o nome de usuario

            string dominio = Environment.UserDomainName; // retorna o nome do computador na rede

            string numeroDeNucleosOuThreads = Environment.ProcessorCount.ToString();

            lbResultado.Text = numeroDeNucleosOuThreads;


        }

        private void btnApplication_Click(object sender, EventArgs e)
        {

            // Application = nos permite trabalhar com algumas propriedades da nossa aplicação

            // Application.Exit(); // finaliza a aplicação

            string exec = Application.ExecutablePath; // mostra o caminho do executavel da minha aplicação

            string pasta = Application.StartupPath; // retorna o caminho onde o executavel está

            Application.Restart(); // reinicia a nossa aplicação e caso esteja rodando modo debug, ele cancela o modo debug

            lbResultado.Text = exec;

        }

        private void btnThread_Click(object sender, EventArgs e)
        {

            // Thread - São linhas de execução de tarefas do sistema



        }
    }
}
