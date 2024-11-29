using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignmet_EF_D2.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Author_Id", "Bref", "JoinDate", "Name", "Password", "Username" },
                values: new object[] { 1, "", new DateOnly(2009, 7, 2), "Habiba Mohamed", "12345", "Habiba" });

            migrationBuilder.InsertData(
                table: "Catalog",
                columns: new[] { "Catalog_Id", "Description", "Name" },
                values: new object[] { 1, "Sports", "Sports" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "News_Id", "Auther_Id", "Bref", "Catalog_Id", "DateTime", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Football", 1, new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "collective game" },
                    { 2, 1, "Padel", 1, new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "individual game" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "News_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "News_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Author_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Catalog_Id",
                keyValue: 1);
        }
    }
}
