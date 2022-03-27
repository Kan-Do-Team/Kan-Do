using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kan_Do.EntityFramework.Migrations
{
    public partial class account_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isProAccount",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isProAccount",
                table: "Accounts");
        }
    }
}
