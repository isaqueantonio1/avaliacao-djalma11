using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoDjalma.Migrations
{
    /// <inheritdoc />
    public partial class telaLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserNameId",
                table: "AplicationsUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNameId",
                table: "AplicationsUsers");
        }
    }
}
