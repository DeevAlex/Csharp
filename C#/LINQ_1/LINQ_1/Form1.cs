using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {

        // fonte dos dados
        List<string> listaNomes;
        List<int> listaNumeros;
        Dictionary<string, double> listaProdutos;
        Dictionary<string, string> listaEstados;

        public Form1()
        {

            InitializeComponent();

            #region Lista de Nomes

            listaNomes = new List<string>();
            listaNomes.Add("Alex");
            listaNomes.Add("Juan Felipe Alves Flores");
            listaNomes.Add("Maria Eduarda Batista de Sousa");
            listaNomes.Add("Bárbara Ohana dos Santos");
            listaNomes.Add("Yasmin Garcia Borges");
            listaNomes.Add("João Arthur Borges Rodrigues");
            listaNomes.Add("Jefferson Ribeiro Vasconcelos Carvalho");
            listaNomes.Add("Carlos");
            listaNomes.Add("Alessandra");
            listaNomes.Add("Gabriel");
            listaNomes.Add("Gloria");

            #endregion

            #region Lista Numeros

            listaNumeros = new List<int>();
            listaNumeros.Add(7);
            listaNumeros.Add(10);
            listaNumeros.Add(21);
            listaNumeros.Add(5);
            listaNumeros.Add(2);
            listaNumeros.Add(8);
            listaNumeros.Add(1);
            listaNumeros.Add(13);

            #endregion

            #region Lista Produtos

            listaProdutos = new Dictionary<string, double>();
            listaProdutos.Add("Apple Iphone 7s Plus", 1899.99);
            listaProdutos.Add("Cabo USB-C 3.1", 79.99);
            listaProdutos.Add("Monitor Dell 24' H2419U", 1399.99);
            listaProdutos.Add("Xiaomi Poco X3 Pro", 2189.99);
            listaProdutos.Add("Mac Mini Mid 11'", 1779.99);
            listaProdutos.Add("Logitech C270 Pro", 249.99);

            #endregion

            #region Lista Estados

            listaEstados = new Dictionary<string, string>();
            listaEstados.Add("Montreal", "Canada");
            listaEstados.Add("Araguaina", "Brasil");
            listaEstados.Add("Seoul", "South Korea");
            listaEstados.Add("Rio de Janeiro", "Brasil");
            listaEstados.Add("São Paulo", "Brasil");
            listaEstados.Add("Madrid", "Espanha");
            listaEstados.Add("Lisboa", "Portugal");
            listaEstados.Add("Busan", "South Korea");
            listaEstados.Add("Vancouver", "Canada");

            #endregion

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // Metodo comum
            // foreach (int num in listaNumeros) // ele percorre toda a lista procutando quem é par 
            // {

            //    if (num % 2 == 0)
            //    {
            //        lista.Items.Add(num);
            //    }

            // }

            // UTILIZANDO LINQ  

            // Obter a fonte dos dados
            // criar a consulta
            // executar a consulta

            // palavras chaves do LINQ - from, where e select

            // consulta:
            // de cada numero que ele pegar na listaNumeros onde numero for divisivel por 2 e o resto seja 0 selecione o numero
            // IEnumerable<int> res = from num in listaNumeros where num % 2 == 0 select num; // aqui vamos ter um resultado já filtrado com os numeros pares

            // executar consulta

            // foreach (int num in res)
            // {
            //    lista.Items.Add(num);
            // }

            IEnumerable<string> res2 = from nome in listaNomes where nome.StartsWith(txtConsulta.Text) select nome;

            // para não precisar do foreach
            lista.Items.AddRange(res2.ToArray());

            // foreach (string nome in res2)
            // {
                
            //    lista.Items.Add(nome);

            // }

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // Operador de Filtragem, a clausula where

            var res = from nome in listaNomes where nome.ToLower().Contains(txtConsulta.Text.ToLower()) select nome;

            lista.Items.AddRange((res.ToArray()));

        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // Operador de ordenação, a clausa orderby (do menor para o maior)

            // var res = from num in listaNumeros orderby num descending select num; // descending é descrescente, ascending é crescente

            // var res = from nome in listaNomes orderby nome select nome; // podemos colocar o descending e o ascending aqui tambem

            var res = from produto in listaProdutos orderby produto.Value descending select produto; // ordendando o valor ou a chave do Dictionary

            foreach (KeyValuePair<string, double> n in res)
            {
                lista.Items.Add("Produto: " + n.Key + ", Preço: R$" + n.Value);
            }

        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {

            // Operadores de Agrupamento

            lista.Items.Clear();

            txtConsulta.Text = "";
                
            var res = from estado in listaEstados group estado by estado.Value; // aqui estamos agrupado os estados pelo valor (O valor é o nome dos paises)

            // listando apenas os paises
            foreach (var grupo in res) // agrupa
            {
                lista.Items.Add(grupo.Key);
                // listando apenas os estados
                foreach (var estado in grupo) // agrupa os estados
                {
                    lista.Items.Add("   " + estado.Key);
                }
            }



        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // Operadores de Agregação - são operadores que computam apenas um valor de uma coleção, exemplo a soma de todos os valores se for uma coleção numerica, ou uma media.

            // int cont1 = listaNomes.Count();
            // int cont2 = (from nome in listaNomes where nome.StartsWith(txtConsulta.Text) select nome).Count() ;

            // lista.Items.Add(cont1 + " nome(s)");
            // if (txtConsulta.Text != "")
            // {
            //    lista.Items.Add(cont2 + " nomes(s) que começa(m) com '" + txtConsulta.Text + "'");
            // } else
            // {
            //    MessageBox.Show("Digite algo na caixa de texto");
            //    return;
            // }

            // double media1 = listaNumeros.Average();
            // lista.Items.Add("");
            // lista.Items.Add(media1 + " media dos valores");

            // var res1 = from num in listaNumeros where num < 10 select num;
            // double media2 = res1.Average();
            // lista.Items.Add(media2 + " media dos valores menores que 10");

            // int soma1 = listaNumeros.Sum();
            // lista.Items.Add(soma1 + " soma dos valores");

            // var res2 = from num in listaNumeros where num < 10 select num;
            // int soma2 = res2.Sum();
            // lista.Items.Add(soma2 + " soma dos valores menores que 10");

            // lista.Items.Add("Maior valor: " + listaNumeros.Max()); // retorna o maior numero na lista
            // lista.Items.Add("Menor valor: " + listaNumeros.Min()); // retorna o menor numero na lista

            // long contagem = listaNumeros.LongCount(); // retorna em formato de long a quantidade de items que tem na coleção, e também aplicado a consulta

            string maiorNome = listaNomes.Aggregate(listaNomes[0], (maior, proximo) => // o primeiro parametro no Aggregate é a semente (não precisa passar) e o proximo é uma função lambda que decidira qual valor retornar
            {

                if (maior.Length > proximo.Length)
                {
                    return maior;
                } else
                {
                    return proximo;
                }

            });

            lista.Items.Add("O maior nome da lista é: " + maiorNome);

        }

        private void btnElemento_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // Operadores de Elemento, também aplicado a consulta

            // int primeiro = listaNumeros.First(); // retorna o primeiro elemento da lista
            int primeiro = listaNumeros.FirstOrDefault(); // retorna o primeiro elemento da lista ou retorna o numero valor do tipo caso não encontre nada

            lista.Items.Add(primeiro);

            // int primeiro = listaNumeros.Last(); // retorna o primeiro elemento da lista
            int ultimo = listaNumeros.LastOrDefault(); // retorna o ultimo elemento da lista ou retorna o numero valor do tipo caso não encontre nada
            lista.Items.Add(ultimo);

            // int elementoEm = listaNumeros.ElementAtOrDefault(3); // retorna o elemento que está na posição x
            int elementoEm = listaNumeros.ElementAtOrDefault(3); // retorna o elemento que está na posição x ou retorna o valor padrão do tipo caso não encontre nada

            lista.Items.Add(elementoEm);

            var consulta = from num in listaNumeros where num > 1000 select num;
            int numero = consulta.FirstOrDefault(); // First(), como a lista não contem nenhum numero maior que 1000 ele gera um erro, mas com o default ele coloca o valor padrão do tipo da variavel

            lista.Items.Add(numero);

        }

        private void btnLambdas_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            // consulta da forma mais verbosa
            // var cons1 = from nome in listaNomes select nome; // comum

            // var cons1 = listaNomes.Select((nome) => nome ); // usando lambda

            // lista.Items.AddRange(cons1.ToArray());

            // var const2 = from nome in listaNomes where nome.StartsWith("G") select nome;

            // var cons2 = listaNomes.Where((nome) => nome.StartsWith("G"));
            // lista.Items.AddRange(cons2.ToArray());

            // var cons3 = from nome in listaNomes orderby nome select nome;

            // var cons3 = listaNomes.OrderBy((nome) => nome);
            // var cons3 = listaNomes.OrderByDescending((nome) => nome);
            // lista.Items.AddRange(cons3.ToArray());

            // var cons4 = from estado in listaEstados group estado by estado.Value;

            // foreach (var pais in cons4)
            // {
            //    lista.Items.Add(pais.Key);
            //    foreach (var estado in pais)
            //    {
            //        lista.Items.Add("   " + estado.Key);
            //    }
            // }

            var cons4 = listaEstados.GroupBy((estado) => estado.Value);

            foreach (var pais in cons4)
            {
                lista.Items.Add(pais.Key);
                foreach (var estado in pais)
                {
                    lista.Items.Add("   " + estado.Key);
                }
            }

        }

    }
}
