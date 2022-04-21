using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kan_Do.EntityFramework.Migrations
{
    public partial class entitysyntax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Board_Accounts_BoardCreatorId",
                table: "Board");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Board_BoardId",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Column",
                table: "Column");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Board",
                table: "Board");

            migrationBuilder.RenameTable(
                name: "Column",
                newName: "Columns");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.RenameTable(
                name: "Board",
                newName: "Boards");

            migrationBuilder.RenameIndex(
                name: "IX_Column_BoardId",
                table: "Columns",
                newName: "IX_Columns_BoardId");

            migrationBuilder.RenameIndex(
                name: "IX_Card_ColumnId",
                table: "Cards",
                newName: "IX_Cards_ColumnId");

            migrationBuilder.RenameIndex(
                name: "IX_Board_BoardCreatorId",
                table: "Boards",
                newName: "IX_Boards_BoardCreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Columns",
                table: "Columns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boards",
                table: "Boards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Boards_Accounts_BoardCreatorId",
                table: "Boards",
                column: "BoardCreatorId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Columns_ColumnId",
                table: "Cards",
                column: "ColumnId",
                principalTable: "Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Boards_BoardId",
                table: "Columns",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boards_Accounts_BoardCreatorId",
                table: "Boards");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Columns_ColumnId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Boards_BoardId",
                table: "Columns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Columns",
                table: "Columns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boards",
                table: "Boards");

            migrationBuilder.RenameTable(
                name: "Columns",
                newName: "Column");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.RenameTable(
                name: "Boards",
                newName: "Board");

            migrationBuilder.RenameIndex(
                name: "IX_Columns_BoardId",
                table: "Column",
                newName: "IX_Column_BoardId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_ColumnId",
                table: "Card",
                newName: "IX_Card_ColumnId");

            migrationBuilder.RenameIndex(
                name: "IX_Boards_BoardCreatorId",
                table: "Board",
                newName: "IX_Board_BoardCreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Column",
                table: "Column",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Board",
                table: "Board",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Board_Accounts_BoardCreatorId",
                table: "Board",
                column: "BoardCreatorId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Board_BoardId",
                table: "Column",
                column: "BoardId",
                principalTable: "Board",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
