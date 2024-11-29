using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignmet_EF_D2.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_News_Auther_Id",
                table: "News",
                column: "Auther_Id");

            migrationBuilder.CreateIndex(
                name: "IX_News_Catalog_Id",
                table: "News",
                column: "Catalog_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Authors_Auther_Id",
                table: "News",
                column: "Auther_Id",
                principalTable: "Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Catalog_Catalog_Id",
                table: "News",
                column: "Catalog_Id",
                principalTable: "Catalog",
                principalColumn: "Catalog_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Authors_Auther_Id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Catalog_Catalog_Id",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_Auther_Id",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_Catalog_Id",
                table: "News");
        }
    }
}
