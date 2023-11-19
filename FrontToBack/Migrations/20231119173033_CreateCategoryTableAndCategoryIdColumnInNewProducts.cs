using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoryTableAndCategoryIdColumnInNewProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "NewProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "NewProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewProducts_CategoryId",
                table: "NewProducts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewProducts_Categories_CategoryId",
                table: "NewProducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewProducts_Categories_CategoryId",
                table: "NewProducts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_NewProducts_CategoryId",
                table: "NewProducts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "NewProducts");

            migrationBuilder.DropColumn(
                name: "SKU",
                table: "NewProducts");
        }
    }
}
