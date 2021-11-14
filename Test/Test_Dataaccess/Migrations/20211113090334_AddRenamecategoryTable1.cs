using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class AddRenamecategoryTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_tbl-category_Category_Id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl-category",
                table: "tbl-category");

            migrationBuilder.RenameTable(
                name: "tbl-category",
                newName: "tbl_category");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_category",
                newName: "Category_Name");

            migrationBuilder.RenameColumn(
                name: "categories_Id",
                table: "tbl_category",
                newName: "Categoru_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category",
                column: "Categoru_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_tbl_category_Category_Id",
                table: "books",
                column: "Category_Id",
                principalTable: "tbl_category",
                principalColumn: "Categoru_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_tbl_category_Category_Id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category");

            migrationBuilder.RenameTable(
                name: "tbl_category",
                newName: "tbl-category");

            migrationBuilder.RenameColumn(
                name: "Category_Name",
                table: "tbl-category",
                newName: "Name");

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
    }
}
