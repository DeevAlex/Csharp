using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class populaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {

            mb.Sql("INSERT INTO PRODUTOS(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Coca-Cola Diet', 'Refrigerante Coca-Cola 350 ml', 4.45, 'Coca-Cola-Diet.jpg', 100, now(), 1)"); // Método que executa as instruções SQL no banco de dados
            mb.Sql("INSERT INTO PRODUTOS(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Lanche de Atum', 'Lanche de Atum com Maionese', 8.71, 'Atum.jpg', 300, now(), 2)"); // Método que executa as instruções SQL no banco de dados
            mb.Sql("INSERT INTO PRODUTOS(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES('Pudim 100g', 'Pudim de Leite Condensado 100g', 6.55, 'Pudim.jpg', 10, now(), 3)"); // Método que executa as instruções SQL no banco de dados

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {

            // Comando sql para deletar a tabela que foi criada caso precise reverter a migração
            mb.Sql("DELETE FROM PRODUTOS;");

        }
    }
}
