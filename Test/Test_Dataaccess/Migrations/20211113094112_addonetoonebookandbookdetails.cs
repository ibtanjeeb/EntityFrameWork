using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class addonetoonebookandbookdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookDetail_id",
                table: "Fluent_Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Book_BookDetail_id",
                table: "Fluent_Book",
                column: "BookDetail_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Book_Fluent_Books_BookDetail_id",
                table: "Fluent_Book",
                column: "BookDetail_id",
                principalTable: "Fluent_Books",
                principalColumn: "BookDetail_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Book_Fluent_Books_BookDetail_id",
                table: "Fluent_Book");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Book_BookDetail_id",
                table: "Fluent_Book");

            migrationBuilder.DropColumn(
                name: "BookDetail_id",
                table: "Fluent_Book");
        }
    }
}
