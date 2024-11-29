using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignmet_EF_D2.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Author_Id", "Bref", "JoinDate", "Name", "Password", "Username" },
                values: new object[] { 2, "", new DateOnly(2005, 8, 31), "Tasnim Mohamed", "12345", "tasnim" });

            migrationBuilder.InsertData(
                table: "Catalog",
                columns: new[] { "Catalog_Id", "Description", "Name" },
                values: new object[] { 2, "Beuaty", "Beuaty" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Author_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Catalog_Id",
                keyValue: 2);
        }
    }
}
