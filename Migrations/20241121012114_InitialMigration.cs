using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DicasSustentaveisGS1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Conteudo = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrasesPreferidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    FraseId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrasesPreferidas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrasesPreferidas_Frases_FraseId",
                        column: x => x.FraseId,
                        principalTable: "Frases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FrasesPreferidas_FraseId",
                table: "FrasesPreferidas",
                column: "FraseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FrasesPreferidas");

            migrationBuilder.DropTable(
                name: "Frases");
        }
    }
}
