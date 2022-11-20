using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMVC.Migrations
{
    public partial class addingtabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lname",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }
    }
}
