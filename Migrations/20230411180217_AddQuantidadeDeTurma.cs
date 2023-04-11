using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantidadeDeTurma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaximoAlunos",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximoAlunos",
                table: "Turmas");
        }
    }
}
