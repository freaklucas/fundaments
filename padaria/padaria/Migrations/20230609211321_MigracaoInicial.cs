using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace padaria.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Padaria",
                columns: table => new
                {
                    PadariaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    PadariaDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PadariaLongDesc = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageThumbUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LancheFavorite = table.Column<bool>(type: "bit", nullable: false),
                    Estoque = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padaria", x => x.PadariaId);
                    table.ForeignKey(
                        name: "FK_Padaria_Categorias_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorias",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Padaria_CategoryId",
                table: "Padaria",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Padaria");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
