using Microsoft.EntityFrameworkCore.Migrations;

namespace Coinrr.Migrations
{
    public partial class UpdateCoinEntityModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Coins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Coins");
        }
    }
}
