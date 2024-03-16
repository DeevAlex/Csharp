using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class populaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {

            mb.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Bebidas', 'bebidas.jpg')"); // Método que executa as instruções SQL no banco de dados
            mb.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Lanches', 'lanches.jpg')"); // Método que executa as instruções SQL no banco de dados
            mb.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Sobremesas', 'sobremesas.jpg')"); // Método que executa as instruções SQL no banco de dados

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {

            // Comando sql para deletar a tabela que foi criada caso precise reverter a migração
            mb.Sql("DELETE FROM CATEGORIAS");

        }
    }
}
