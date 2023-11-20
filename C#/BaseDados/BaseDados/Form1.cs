using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// devemos adicinar a DLL do SQL Server CE na referencia do projeto
// devemos importar para usa-lo em nossos projetos

using System.Data.SqlServerCe;
using System.IO;

// SQLite

using System.Data.SQLite;

// MySQL

using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            #region SQL Server CE

            // string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"DataSource = " + baseDados + "; Password = '457321'"; // endereço onde vai ficar a base de dados

            // SqlCeEngine db = new SqlCeEngine(stringConnection);

            // if (!File.Exists(baseDados))
            // {

            //    db.CreateDatabase(); // cria a base de dados caso não exista

            // }

            // db.Dispose(); // para se livrar dos recursos que foram utilizados

            // SqlCeConnection conexao = new SqlCeConnection(stringConnection);

            // try
            // {

            //    conexao.Open(); // abre a conexão com a base de dados da stringConnection

            //    labelResultado.Text += " Conectado";

            // }
            // catch (Exception ex)
            // {

            //    MessageBox.Show("Erro: " + ex.Message);

            // }
            // finally
            // {

            //    conexao.Close(); // Encerra a conexão com a base de dados

            // }

            #endregion

            #region SQLite

            // string baseDados = Application.StartupPath + @"\DB\dbSQLite.db"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"Data Source = " + baseDados + "; Version = 3"; // caso apareça o erro: Only SQLite Version 3 is supported at this time, coloque a version aqui para 3, que corrigira o poblema

            // if (!File.Exists(baseDados))
            // {

            //    SQLiteConnection.CreateFile(baseDados); // cria a base de dados caso não exista

            // }

            // SQLiteConnection conexao = new SQLiteConnection(stringConnection);

            // try
            // {

            //    conexao.Open(); // abre a conexão com a base de dados da stringConnection

            //    labelResultado.Text += " Conectado";

            // }
            // catch (Exception ex)
            // {

            //    MessageBox.Show("Erro: " + ex.Message);

            // } 
            // finally
            // {

            //    conexao.Close(); // Encerra a conexão com a base de dados

            // }

            #endregion

            #region MySQL

            string stringConnection1 = "server=localhost;User Id =root;password=root123"; // quando não tem a base de dados criada
            // string stringConnection2 = "server=localhost;User Id =root;database=curso_db;password=root123"; // quando já está criada

            MySqlConnection conexao = new MySqlConnection(stringConnection1);

            try
            {

                conexao.Open(); // abre a conexão com a base de dados da stringConnection

                labelResultado.Text += "Conectado";

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db"; // verifica a existencia da base de dados caso falso ele cria, caso verdadeiro não cria

                comando.ExecuteNonQuery(); // executa o comando acima

                labelResultado.Text += "Base de Dados Criada";

                comando.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);

            }
            finally
            {

                conexao.Close(); // Encerra a conexão com a base de dados

            }

            #endregion

        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {

            #region SQLServerCE

            // string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"DataSource = " + baseDados + "; Password = '457321'"; // endereço onde vai ficar a base de dados

            // SqlCeConnection conexao = new SqlCeConnection(stringConnection);

            // try
            // {

            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas(ID INT NOT NULL PRIMARY KEY, NOME NVARCHAR(50), EMAIL NVARCHAR(50))"; // Comando para cria a tabela
            //    comando.ExecuteNonQuery(); // executa o comando de executar a tabela

            //    labelResultado.Text = "Resultado: Tabela criada";

            //    comando.Dispose();

            // } catch (Exception ex)
            // {
            //    labelResultado.Text = "Erro: " + ex.Message;
            // } finally
            // {
            //    conexao.Close();
            // }

            #endregion

            #region SQLite

            // string baseDados = Application.StartupPath + @"\DB\dbSQLite.db"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"Data Source = " + baseDados + "; Version = 3"; // caso apareça o erro: Only SQLite Version 3 is supported at this time, coloque a version aqui para 3, que corrigira o poblema

            // SQLiteConnection conexao = new SQLiteConnection(stringConnection);

            // try
            // {

            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();

            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas(ID INT NOT NULL PRIMARY KEY, NOME NVARCHAR(50), EMAIL NVARCHAR(50))"; // Comando para cria a tabela
            //    comando.ExecuteNonQuery(); // executa o comando de executar a tabela

            //    labelResultado.Text = "Resultado: Tabela criada";

            //    comando.Dispose();

            // }
            // catch (Exception ex)
            // {
            //    labelResultado.Text = "Erro: " + ex.Message;
            // }
            // finally
            // {
            //    conexao.Close();
            // }

            #endregion

            #region MySQL

            string stringConnection = "server=localhost;User Id =root;database=curso_db;password=root123"; // quando já está criada

            MySqlConnection conexao = new MySqlConnection(stringConnection);

            try
            {

                conexao.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(ID INT NOT NULL, NOME VARCHAR(50), EMAIL VARCHAR(50), PRIMARY KEY(ID))"; // Comando para cria a tabela
                comando.ExecuteNonQuery(); // executa o comando de executar a tabela

                labelResultado.Text = "Resultado: Tabela criada";

                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro: " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            #endregion

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            #region SQLServerCE

            // string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"DataSource = " + baseDados + "; Password = '457321'"; // endereço onde vai ficar a base de dados

            // SqlCeConnection conexao = new SqlCeConnection(stringConnection);

            // try
            // {

            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VAlUES(" + id + ",'" + nome + "','" + email + "')"; // Comando para cria a tabela
            //    comando.ExecuteNonQuery(); // executa o comando de inserir dados na tabela

            //    labelResultado.Text = "Resultado: Dados Inseridos!";

            //    comando.Dispose();

            // }
            // catch (Exception ex)
            // {
            //    labelResultado.Text = "Erro: " + ex.Message;
            // }
            // finally
            // {
            //    conexao.Close();
            // }

            #endregion

            #region SQLite

            string baseDados = Application.StartupPath + @"\DB\dbSQLite.db"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            string stringConnection = @"Data Source = " + baseDados + "; Version = 3"; // caso apareça o erro: Only SQLite Version 3 is supported at this time, coloque a version aqui para 3, que corrigira o poblema

            SQLiteConnection conexao = new SQLiteConnection(stringConnection);

            try
            {

                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();

                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VAlUES(" + id + ",'" + nome + "','" + email + "')"; // Comando para cria a tabela
                comando.ExecuteNonQuery(); // executa o comando de executar a tabela

                labelResultado.Text = "Resultado: Dados Inseridos!";

                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro: " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            #endregion

            #region MySQL

            //string stringConnection = "server=localhost;User Id =root;database=curso_db;password=root123"; // quando já está criada

            //MySqlConnection conexao = new MySqlConnection(stringConnection);

            //try
            //{

            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();

            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VAlUES(" + id + ",'" + nome + "','" + email + "')"; // Comando para cria a tabela
            //    comando.ExecuteNonQuery(); // executa o comando de executar a tabela

            //    labelResultado.Text = "Resultado: Dados Inseridos!";

            //    comando.Dispose();

            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro: " + ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            labelResultado.Text = "Resultado:";
            lista.Rows.Clear(); // limpa todas as linhas da lista

            #region SQLServerCE

            // string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"DataSource = " + baseDados + "; Password = '457321'"; // endereço onde vai ficar a base de dados

            // SqlCeConnection conexao = new SqlCeConnection(stringConnection);

            // try
            // {

            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
            //    }

            //    DataTable dados = new DataTable(); // é uma tabela que recebera todos os dados (inserimos primeiro aqui para que ele seja tratado quem trata é um adaptador)

            //    SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter(query, stringConnection); // ele é quem preenche a tabela com os dados

            //    conexao.Open();

            //    sqlCeDataAdapter.Fill(dados); // aqui estamos mandando o adaptador preencher a tabela com os dados

            //    foreach (DataRow linha in dados.Rows) // estamos passando por cada linha e colocamos os dados que estão na linha dentro da lista
            //    {

            //        lista.Rows.Add(linha.ItemArray); // cada linha é um array de colunas

            //    }

            //    labelResultado.Text = "Resultado: Procurando...";

            // }
            // catch (Exception ex)
            // {
            //    labelResultado.Text = "Erro: " + ex.Message;
            // }
            // finally
            // {
            //    conexao.Close();
            // }

            #endregion

            #region SQLite

            string baseDados = Application.StartupPath + @"\DB\dbSQLite.db"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            string stringConnection = @"Data Source = " + baseDados + "; Version = 3"; // caso apareça o erro: Only SQLite Version 3 is supported at this time, coloque a version aqui para 3, que corrigira o poblema

            SQLiteConnection conexao = new SQLiteConnection(stringConnection);

            try
            {

                string query = "SELECT * FROM pessoas";

                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable(); // é uma tabela que recebera todos os dados (inserimos primeiro aqui para que ele seja tratado quem trata é um adaptador)

                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(query, stringConnection); // ele é quem preenche a tabela com os dados

                conexao.Open();

                sQLiteDataAdapter.Fill(dados); // aqui estamos mandando o adaptador preencher a tabela com os dados

                foreach (DataRow linha in dados.Rows) // estamos passando por cada linha e colocamos os dados que estão na linha dentro da lista
                {

                    lista.Rows.Add(linha.ItemArray); // cada linha é um array de colunas

                }

                labelResultado.Text = "Resultado: Procurando...";

            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro: " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            #endregion

            #region MySQL

            // string stringConnection = "server=localhost;User Id =root;database=curso_db;password=root123"; // quando já está criada

            // MySqlConnection conexao = new MySqlConnection(stringConnection);

            // try
            // {

            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome = '" + txtNome.Text + "'";
            //    }

            //    DataTable dados = new DataTable(); // é uma tabela que recebera todos os dados (inserimos primeiro aqui para que ele seja tratado quem trata é um adaptador)

            //    MySqlDataAdapter sQLiteDataAdapter = new MySqlDataAdapter(query, stringConnection); // ele é quem preenche a tabela com os dados

            //    conexao.Open();

            //    sQLiteDataAdapter.Fill(dados); // aqui estamos mandando o adaptador preencher a tabela com os dados

            //    foreach (DataRow linha in dados.Rows) // estamos passando por cada linha e colocamos os dados que estão na linha dentro da lista
            //    {

            //        lista.Rows.Add(linha.ItemArray); // cada linha é um array de colunas

            //    }

            //    labelResultado.Text = "Resultado: Procurando...";

            // }
            // catch (Exception ex)
            // {
            //    labelResultado.Text = "Erro: " + ex.Message;
            // }
            // finally
            // {
            //    conexao.Close();
            // }

            #endregion

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            #region SQLServerCE

            // string baseDados = Application.StartupPath + @"\DB\dbSQLServer.sdf"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            // string stringConnection = @"DataSource = " + baseDados + "; Password = '457321'"; // endereço onde vai ficar a base de dados

            // SqlCeConnection conexao = new SqlCeConnection(stringConnection);

            // try
            // {

            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();

            //    comando.Connection = conexao;


            //    // as celulas são os campos, Ex: ID, NOME, EMAIL.
            //    int id = (int)lista.SelectedRows[0].Cells[0].Value; // aqui nos pegas a linha selecionada, depois a celula e o valor e convertemos o valor para um inteiro

            //    // DELETE FROM pessoas - APAGA TODOS OS REGISTROS (CUIDADO)
            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'"; // Comando para cria a tabela
            //    comando.ExecuteNonQuery(); // executa o comando de inserir dados na tabela

            //    labelResultado.Text = "Resultado: Dado deletado!";

            //    comando.Dispose();

            // }
            // catch (Exception ex)
            // {
            //    labelResultado.Text = "Erro: " + ex.Message;
            // }
            // finally
            // {
            //    conexao.Close();
            // } 

            #endregion

            #region SQLite

            string baseDados = Application.StartupPath + @"\DB\dbSQLite.db"; // o startupPath é o endereço de onde está o executavel, tem que ter a extenção <qualquer nome>.sdf
            string stringConnection = @"Data Source = " + baseDados + "; Version = 3"; // caso apareça o erro: Only SQLite Version 3 is supported at this time, coloque a version aqui para 3, que corrigira o poblema

            SQLiteConnection conexao = new SQLiteConnection(stringConnection);

            try
            {

                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();

                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VAlUES(" + id + ",'" + nome + "','" + email + "')"; // Comando para cria a tabela
                comando.ExecuteNonQuery(); // executa o comando de executar a tabela

                labelResultado.Text = "Resultado: Dados Inseridos!";

                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro: " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            #endregion

            #region MySQL

            //string stringConnection = "server=localhost;User Id =root;database=curso_db;password=root123"; // quando já está criada

            //MySqlConnection conexao = new MySqlConnection(stringConnection);

            //try
            //{

            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();

            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VAlUES(" + id + ",'" + nome + "','" + email + "')"; // Comando para cria a tabela
            //    comando.ExecuteNonQuery(); // executa o comando de executar a tabela

            //    labelResultado.Text = "Resultado: Dados Inseridos!";

            //    comando.Dispose();

            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro: " + ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

        }

    }
    
}
