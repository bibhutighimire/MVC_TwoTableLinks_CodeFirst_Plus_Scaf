using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDAYTWO.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci"),
                    publicationdate = table.Column<DateTime>(type: "date", nullable: false),
                    checkedoutdate = table.Column<DateTime>(type: "date", nullable: false),
                    duedate = table.Column<DateTime>(type: "date", nullable: false),
                    returnedate = table.Column<DateTime>(type: "date", nullable: true),
                    author_id = table.Column<int>(type: "int(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.id);
                    table.ForeignKey(
                        name: "FK_Of_Author",
                        column: x => x.author_id,
                        principalTable: "Author",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { -1, "Author One" },
                    { -2, "Author Two" },
                    { -3, "Author Three" },
                    { -4, "Author Four" },
                    { -5, "Author Five" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "author_id", "checkedoutdate", "duedate", "publicationdate", "returnedate", "title" },
                values: new object[] { -1, -2, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title One" });

            migrationBuilder.CreateIndex(
                name: "FK_Of_Author",
                table: "Book",
                column: "author_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
