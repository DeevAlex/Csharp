using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            // limpar a lista antes de gerar o codigo abaixo
            lista.Items.Clear();

            #region List

            // antes

            string[] nomes = new string[3];

            nomes[0] = "Julia";
            nomes[1] = "Juliana";
            nomes[2] = "Juliano";

            // lista generica
            List<string> nomes2 = new List<string>();

            // adicionar
            nomes2.Add("Marina"); // 0
            nomes2.Add("Alex"); // 1 // o parametro aqui deve ser o mesmo do que está entre os <> da List ali em cima
            nomes2.Add("Johnson"); // 2
            nomes2.Add("Mike"); // 3

            // adicionar o valor da posição do array que a gente passa como parametro
            nomes2.AddRange(nomes);

            // retorna um valor booleano se contem o valor x na lista
            // if (nomes2.Contains("Johnson"))
            // {
            //    MessageBox.Show("Contém");
            // } else
            // {
            //    MessageBox.Show("Não contém");
            // }

            // retorna quantos valores tem dentro da lista
            // MessageBox.Show("Numero de Elementos: " + nomes2.Count());

            // Ordena a Lista em ordem alfabetica
            // nomes2.Sort();

            // retorna o indice do valor na lista, quando retorna -1 é porque não está na lista
            //MessageBox.Show("Johnson está no indice: " + nomes2.IndexOf("Johnson"));

            // remover
            //nomes2.Remove("Mike");

            // para mostrar na listbox

            // insere um valor na posição x
            // nomes2.Insert(2, "Vitoria");

            // remover um valor na posição x
            // nomes2.RemoveAt(2);

            // limpa toda a lista
            //nomes2.Clear();
            
            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }

            #endregion


        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            #region HashSet

            // a lista do tipo HashSet é semelhante a uma lista do tipo List porém ela não permite items repetidos

            HashSet<string> veiculos = new HashSet<string>()
            {
                // podemos adicionar items na lista na inicialização assim:
                "Carro", "Moto",
                "Aviao", "Helicoptero", "Barco"
            };

            // na lista HashSet não retorna o valor que esta no indice assim veiculos[1]

            // para pegar o valor na posição x na lista HashSet tem que ser assim:
            //MessageBox.Show(veiculos.ElementAt(2));

            // adicionando - no caso a HashSet não tem o addRange
            // veiculos.Add("Citroen C4");

            // if (veiculos.Add("Moto"))
            // {
            //    MessageBox.Show("Item adicionado");
            // } else
            // {
            //    MessageBox.Show("Item não adicionado");
            // }

            // if (veiculos.Contains("Barco"))
            // {
            //    MessageBox.Show("Contém");
            // } else
            // {
            //    MessageBox.Show("Não Contém");
            // }

            //veiculos.Remove("Barco");

            //veiculos.Count();

            //veiculos.Clear();

            // também tem na lista do tipo List:

            // retorna o valor do(a) primeiro/cabeça da lista HashSet
            //veiculos.First();

            // retorna o valor da ultima posição/calda da lista HashSet
            //veiculos.Last();

            foreach (string veiculo in veiculos)
            {
                lista.Items.Add(veiculo);
            }

            #endregion

        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {

            #region Dictionary

            lista.Items.Clear();

            // Dictionary<tipo da chave, tipo do elemento>
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 0, "Gabriel" },
                { 50, "Joana" },
                { 150, "Pietra" },
            };

            // não podemos adicionar a mesma chave se ela ja existe, porém podemos ter os mesmos valores
            alunos.Add(100, "Alex");
            alunos.Remove(0);

            // percorrer um dictionary usando um foreach:
            foreach(KeyValuePair<int, string> valores in alunos)
            {
                // mostra chave e valor na lista:
                //lista.Items.Add(valores); - Output: [chave, valor]
                lista.Items.Add(valores.Key + " - " + valores.Value); // acessando apenas a chave e o valor sem os []
            }

            // mostrar quantos elementos tem na lista
            //alunos.Count();

            // para limpar a lista
            //alunos.Clear();

            // verifica se contém a chave e retorna um boolean se existe ou não na lista
            //alunos.ContainsKey(0);

            // verifica se contém o valor e retorna um boolean se existe ou não na lista
            //alunos.ContainsValue("Joana");

            // Retorna o primeiro/cabeça par (exemplo de par: [chave, valor]) da lista, para acessar chave/valor alunos.First().key/value
            //alunos.First();

            // Retorna o(a) ultimo/calda par (exemplo de par: [chave, valor]) da lista, para acessar chave/valor alunos.First().key/value
            //alunos.Last();

            #endregion


        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {

            #region SortedList

            lista.Items.Clear();

            // lista ordenada - usa menos memoria
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Danny" },
                { 10, "Gabriel" },
                { 17, "Arthur" },
            };

            alunos.Add(14, "Roberto");

            // remover pelo indice
            // alunos.remove(27);
            // alunos.RemoveAt(10);

            // alunos.Count();

            // retorna um boolean se contém ou não a chave x
            // alunos.ContainsKey(57);

            // retorna um boolean se contém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // retorna um boolean se con117. SortedDictionarytém ou não o valor x
            // alunos.ContainsValue("Alex");

            // alunos.Reverse(), inverte a ordem em que a lista estava
            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item);
            }

            #endregion

        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {

            #region SortedDictionary

            lista.Items.Clear();

            // usa mais memoria em relação a SortedList, porém tem operações mais rapidas em inserções e remoções de dados por exemplo, é mais diferenças tecnicas 
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                // ordena na ordem crescente e na ordem alfabetica
                { 4512, "Gabriel" },
                { 1542, "Arthur" },
                { 2145, "Danny" },
            };

            alunos.Add(5478, "Flavio");

            // alunos.Remove(120);

            // alunos.Count();

            // alunos.Clear();

            // alunos.ContainsKey(15);

            // alunos.ContainsValue("Alex");

            // aqui você coloca o indice, o indice é diferente da chave que foi colocada na adição a lista
            MessageBox.Show("Elemento #0: " + alunos.ElementAt(0).ToString());

            // aqui podemos colocar o alunos.Reverse(); também
            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item);
            }

            #endregion

        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {

            #region SortedSet

            lista.Items.Clear();

            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Jonas",
                "Bruna",
                "Alex",
                "Simone",
                "Marina",
            };

            // if (!nomes.Add("Claudio"))
            // {
            //    MessageBox.Show("Não pode repetir o valor");
            // }

            // nomes.Remove("Simone");
            // MessageBox.Show(nomes.ElementAt(2));
            // nomes.First();
            // nomes.Last();
            // nomes.Count();
            // MessageBox.Show(nomes.Count().ToString());

            // podemos colocar na ordem decrescente usando nomes.reverse()
            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }

            #endregion

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {

            #region Queue

            // Conceito FIFO - Fist In, Fist Out

            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Alex"); // Adiciona no final da fila
            fila.Enqueue("Daniel");
            fila.Enqueue("Arthur");

            MessageBox.Show(fila.Count.ToString());

            foreach (string item in fila) 
            {
                lista.Items.Add(item);
            }

            // MessageBox.Show("Primeiro item da fila: " + fila.Peek()); // pega o objeto no inicio da fila sem remover
            // MessageBox.Show("Primeiro item da fila: " + fila.Dequeue()); // pega o objeto no inicio da fila e vai remover
            // MessageBox.Show(fila.Count.ToString());
            // fila.Clear(); // limpar todos os elementos

            // fila.First(); // retorna o primeiro elemento
            // fila.Last(); // retorna o ultimo elemento

            while (fila.Count > 0)
            {
                MessageBox.Show("Primeiro item da fila: " + fila.Dequeue()); // pega o objeto no inicio da fila e vai remover
                MessageBox.Show(fila.Count.ToString());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }

            #endregion

        }

        private void btnStack_Click(object sender, EventArgs e)
        {

            #region Stack

            // Conceito FILO - First In, Last Out

            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Alex"); // adiciona no final da pilha
            pilha.Push("Daniel");
            pilha.Push("Arthur");

            MessageBox.Show(pilha.Count.ToString());

            foreach (string item in pilha)
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show("Elemento no Topo: " + pilha.Peek()); // pega o elemento que está no topo da pilha sem remover
            //MessageBox.Show(pilha.Count.ToString());

            //MessageBox.Show("Elemento removido do Topo: " + pilha.Pop()); // remove o ultimo elemento
            //MessageBox.Show(pilha.Count.ToString());

            // pilha.Clear(); // limpar todos os elementos

            while (pilha.Count > 0)
            {
                MessageBox.Show("Elemento removido do topo da pilha: " + pilha.Pop()); // pega o objeto no inicio da fila e vai remover
                MessageBox.Show(pilha.Count.ToString());
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }

            #endregion

        }
    }
}
