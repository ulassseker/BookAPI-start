using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApiProject.Migrations
{
    public partial class translator3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Books_BookId",
                table: "Translator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Translator",
                table: "Translator");

            migrationBuilder.RenameTable(
                name: "Translator",
                newName: "Translators");

            migrationBuilder.RenameIndex(
                name: "IX_Translator_BookId",
                table: "Translators",
                newName: "IX_Translators_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translators",
                table: "Translators",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translators_Books_BookId",
                table: "Translators",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translators_Books_BookId",
                table: "Translators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Translators",
                table: "Translators");

            migrationBuilder.RenameTable(
                name: "Translators",
                newName: "Translator");

            migrationBuilder.RenameIndex(
                name: "IX_Translators_BookId",
                table: "Translator",
                newName: "IX_Translator_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translator",
                table: "Translator",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Books_BookId",
                table: "Translator",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
