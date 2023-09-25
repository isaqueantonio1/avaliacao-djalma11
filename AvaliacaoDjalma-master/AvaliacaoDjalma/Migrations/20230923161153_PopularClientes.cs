using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoDjalma.Migrations
{
    /// <inheritdoc />
    public partial class PopularClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes(Nome, Celular, DataNasc, UsuarioId) " +
                "VALUES('Antonio','1198348948','19/02/2005','1')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
