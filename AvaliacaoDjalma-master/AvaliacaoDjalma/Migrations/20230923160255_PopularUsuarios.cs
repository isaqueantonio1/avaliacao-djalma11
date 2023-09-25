using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoDjalma.Migrations
{
    /// <inheritdoc />
    public partial class PopularUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios(UserName, UserPass, Nome, Celular) " +
                "VALUES('Lucas123','123','Lucas','11994680600')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
