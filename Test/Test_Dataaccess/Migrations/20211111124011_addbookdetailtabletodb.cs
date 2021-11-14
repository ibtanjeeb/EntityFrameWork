using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class addbookdetailtabletodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookDetail_id",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    BookDetail_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfChapters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofPages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.BookDetail_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_BookDetail_id",
                table: "books",
                column: "BookDetail_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_books_BookDetails_BookDetail_id",
                table: "books",
                column: "BookDetail_id",
                principalTable: "BookDetails",
                principalColumn: "BookDetail_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_BookDetails_BookDetail_id",
                table: "books");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_books_BookDetail_id",
                table: "books");

            migrationBuilder.DropColumn(
                name: "BookDetail_id",
                table: "books");
        }
    }
}
