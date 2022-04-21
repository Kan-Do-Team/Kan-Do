using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kan_Do.EntityFramework.Migrations
{
    public partial class updatecardobject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardReferenceNumber",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardReferenceNumber",
                table: "Cards");
        }
    }
}
