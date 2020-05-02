using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApiProject.Migrations
{
    public partial class translator2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Authors_AuthorId",
                table: "Translator");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Translator",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Translator_AuthorId",
                table: "Translator",
                newName: "IX_Translator_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Books_BookId",
                table: "Translator",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Books_BookId",
                table: "Translator");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Translator",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Translator_BookId",
                table: "Translator",
                newName: "IX_Translator_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Authors_AuthorId",
                table: "Translator",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
