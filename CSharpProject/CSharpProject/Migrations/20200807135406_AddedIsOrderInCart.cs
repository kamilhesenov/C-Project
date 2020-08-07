using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpProject.Migrations
{
    public partial class AddedIsOrderInCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOrder",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "IsOrder",
                table: "Carts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOrder",
                table: "Carts");

            migrationBuilder.AddColumn<bool>(
                name: "IsOrder",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
