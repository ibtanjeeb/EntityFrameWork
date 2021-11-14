using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class AddManytomanyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fluent_BookinAuthors_fluenr_Authors_Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors");

            migrationBuilder.DropIndex(
                name: "IX_fluent_BookinAuthors_Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors");

            migrationBuilder.DropColumn(
                name: "Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "fluent_BookinAuthors",
                newName: "Author_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Book_Id",
                table: "fluent_BookinAuthors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_fluent_BookinAuthors_Author_Id",
                table: "fluent_BookinAuthors",
                column: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_fluent_BookinAuthors_fluenr_Authors_Author_Id",
                table: "fluent_BookinAuthors",
                column: "Author_Id",
                principalTable: "fluenr_Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fluent_BookinAuthors_Fluent_Book_Book_Id",
                table: "fluent_BookinAuthors",
                column: "Book_Id",
                principalTable: "Fluent_Book",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fluent_BookinAuthors_fluenr_Authors_Author_Id",
                table: "fluent_BookinAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_fluent_BookinAuthors_Fluent_Book_Book_Id",
                table: "fluent_BookinAuthors");

            migrationBuilder.DropIndex(
                name: "IX_fluent_BookinAuthors_Author_Id",
                table: "fluent_BookinAuthors");

            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "fluent_BookinAuthors",
                newName: "AuthorId");

            migrationBuilder.AlterColumn<int>(
                name: "Book_Id",
                table: "fluent_BookinAuthors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_fluent_BookinAuthors_Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors",
                column: "Fluenr_AuthorAuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_fluent_BookinAuthors_fluenr_Authors_Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors",
                column: "Fluenr_AuthorAuthorId",
                principalTable: "fluenr_Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
