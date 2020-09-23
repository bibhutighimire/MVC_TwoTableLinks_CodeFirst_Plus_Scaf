using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDAYTWO.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "checkedoutdate", "duedate", "publicationdate", "returnedate" },
                values: new object[] { new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "author_id", "checkedoutdate", "duedate", "publicationdate", "returnedate", "title" },
                values: new object[] { -3, -2, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title Three" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "author_id", "checkedoutdate", "duedate", "publicationdate", "returnedate", "title" },
                values: new object[] { -2, -2, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Title Two" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: -1,
                columns: new[] { "checkedoutdate", "duedate", "publicationdate", "returnedate" },
                values: new object[] { new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
