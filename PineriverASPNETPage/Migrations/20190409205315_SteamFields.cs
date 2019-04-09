using Microsoft.EntityFrameworkCore.Migrations;

namespace PineriverASPNETPage.Migrations
{
    public partial class SteamFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Steam_ID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Steam_Name",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Steam_ID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Steam_Name",
                table: "AspNetUsers");
        }
    }
}
