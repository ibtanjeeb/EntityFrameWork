using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class AddRenamecategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Categories_Category_Id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "tbl-category");

            migrationBuilder.RenameColumn(
                name: "Categoru_Id",
                table: "tbl-category",
                newName: "categories_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl-category",
                table: "tbl-category",
                column: "categories_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_tbl-category_Category_Id",
                table: "books",
                column: "Category_Id",
                principalTable: "tbl-category",
                principalColumn: "categories_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_tbl-category_Category_Id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl-category",
                table: "tbl-category");

            migrationBuilder.RenameTable(
                name: "tbl-category",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "categories_Id",
                table: "Categories",
                newName: "Categoru_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Categoru_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_Categories_Category_Id",
                table: "books",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Categoru_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
