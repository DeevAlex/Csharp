using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Formulario : Form
    {

        // lista dinamica
        List<Pessoa> pessoas;

        public Formulario()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            txtEstadoCivil.Items.Add("Solteiro(a)");
            txtEstadoCivil.Items.Add("Casado(a)"); // adicionando items no ComboCollection de forma dinamica
            txtEstadoCivil.Items.Add("Viuvo(a)");
            txtEstadoCivil.Items.Add("Separado(a)");

            txtEstadoCivil.SelectedIndex = 0; // define qual item vai ser selecionado e colocado no ComboCollection
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Pessoa p in pessoas)
            {
                
                if (p.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(p);
                }

            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome"); // mostra caixa de dialogo mostrando essa mensagem 
                txtNome.Focus(); // já seleciona o campo 
                return;
            }

            if (txtTelefone.Text == " (  )      -") // verificando se o input com mask está vazio, vá na mask dele e copie o preview e cole o preview ali nas "" e pronto
            {
                MessageBox.Show("Preencha o campo telefone"); // mostra caixa de dialogo mostrando essa mensagem 
                txtTelefone.Focus(); // já seleciona o campo 
                return;
            }

            char sexo;

            if (Masculino.Checked) {
                sexo = 'M';
            } else if (Feminino.Checked) {
                sexo = 'F';
            } else
            {
                sexo = 'O';
            }

            Pessoa pe = new Pessoa();

            pe.Nome = txtNome.Text;
            pe.DataNascimento = txtDataNascimento.Text;
            pe.EstadoCivil = txtEstadoCivil.SelectedItem.ToString();
            pe.Telefone = txtTelefone.Text;
            pe.CasaPropria = CheckCasa.Checked;
            pe.Veiculo = CheckVeiculo.Checked;
            pe.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(pe);
            } else
            {
                pessoas[index] = pe;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty); // podemos usar um evento dentro de outro é so fazer assim
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = txtLista.SelectedIndex; // atribui o valor do item selecionado da caixa de texto
            pessoas.RemoveAt(indice); // remove a posição x
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtEstadoCivil.SelectedIndex = 0;
            txtTelefone.Text = "";
            CheckCasa.Checked = false;
            CheckVeiculo.Checked = false;
            Masculino.Checked = false;
            Feminino.Checked = false;
            Outro.Checked = false;
            txtNome.Focus();
        }

        private void Listar()
        {
            txtLista.Items.Clear(); // limpa a caixa de texto
            foreach (Pessoa p in pessoas)
            {
                txtLista.Items.Add(p.Nome); // adiciona items na lista
            }
        }

        private void txtLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = txtLista.SelectedIndex;
            Pessoa p = pessoas[indice]; // vai atribuir a pessoa selecionada nessa variavel p

            txtNome.Text = p.Nome;
            txtDataNascimento.Text = p.DataNascimento;
            txtEstadoCivil.Text = p.EstadoCivil;
            txtTelefone.Text = p.Telefone;
            CheckCasa.Checked = p.CasaPropria;
            CheckVeiculo.Checked = p.Veiculo;
            
            switch(p.Sexo)
            {
                case 'M':
                    Masculino.Checked = true;
                    break;
                case 'F':
                    Feminino.Checked = true;
                    break;
                default:
                    Outro.Checked = true;
                    break;
            }

        }
    }
}
