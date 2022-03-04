using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkPress.Data.Migrations
{
    public partial class changedIconValueName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IconValue",
                table: "Icons",
                newName: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Icons",
                newName: "IconValue");
        }
    }
}
