using Microsoft.EntityFrameworkCore.Migrations;

namespace Morgenmadsbuffeten.Data.Migrations
{
    public partial class newschema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderedBreakfast",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Receptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OrderedBreakfast",
                table: "Receptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "Receptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
