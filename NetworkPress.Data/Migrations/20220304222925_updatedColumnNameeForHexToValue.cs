using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkPress.Data.Migrations
{
    public partial class updatedColumnNameeForHexToValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hex",
                table: "Colors",
                newName: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Colors",
                newName: "Hex");
        }
    }
}
