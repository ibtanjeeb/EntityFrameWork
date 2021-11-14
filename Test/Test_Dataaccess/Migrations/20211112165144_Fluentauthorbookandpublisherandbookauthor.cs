using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Dataaccess.Migrations
{
    public partial class Fluentauthorbookandpublisherandbookauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fluenr_Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fluenr_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "fluent_Publishers",
                columns: table => new
                {
                    Publisher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fluent_Publishers", x => x.Publisher_Id);
                });

            migrationBuilder.CreateTable(
                name: "fluent_BookinAuthors",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Fluenr_AuthorAuthorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fluent_BookinAuthors", x => x.Book_Id);
                    table.ForeignKey(
                        name: "FK_fluent_BookinAuthors_fluenr_Authors_Fluenr_AuthorAuthorId",
                        column: x => x.Fluenr_AuthorAuthorId,
                        principalTable: "fluenr_Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fluent_Book",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PriceRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fluent_PublisherPublisher_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluent_Book", x => x.Book_Id);
                    table.ForeignKey(
                        name: "FK_Fluent_Book_fluent_Publishers_Fluent_PublisherPublisher_Id",
                        column: x => x.Fluent_PublisherPublisher_Id,
                        principalTable: "fluent_Publishers",
                        principalColumn: "Publisher_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Book_Fluent_PublisherPublisher_Id",
                table: "Fluent_Book",
                column: "Fluent_PublisherPublisher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_fluent_BookinAuthors_Fluenr_AuthorAuthorId",
                table: "fluent_BookinAuthors",
                column: "Fluenr_AuthorAuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fluent_Book");

            migrationBuilder.DropTable(
                name: "fluent_BookinAuthors");

            migrationBuilder.DropTable(
                name: "fluent_Publishers");

            migrationBuilder.DropTable(
                name: "fluenr_Authors");
        }
    }
}
