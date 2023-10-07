using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Administration.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategorieen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategorieen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductCategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producten_ProductCategorieen_ProductCategorieId",
                        column: x => x.ProductCategorieId,
                        principalTable: "ProductCategorieen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producten_ProductCategorieId",
                table: "Producten",
                column: "ProductCategorieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producten");

            migrationBuilder.DropTable(
                name: "ProductCategorieen");
        }
    }
}
