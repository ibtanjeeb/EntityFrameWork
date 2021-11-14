using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class addfluentcategorytableo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_fluenttbl_Category",
                table: "fluenttbl_Category");

            migrationBuilder.RenameTable(
                name: "fluenttbl_Category",
                newName: "Fluent_Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Category",
                table: "Fluent_Category",
                column: "Categoru_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Category",
                table: "Fluent_Category");

            migrationBuilder.RenameTable(
                name: "Fluent_Category",
                newName: "fluenttbl_Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fluenttbl_Category",
                table: "fluenttbl_Category",
                column: "Categoru_Id");
        }
    }
}
