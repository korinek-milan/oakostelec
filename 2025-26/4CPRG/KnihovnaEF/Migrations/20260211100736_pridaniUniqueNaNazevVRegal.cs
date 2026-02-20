using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnihovnaEF.Migrations
{
    /// <inheritdoc />
    public partial class pridaniUniqueNaNazevVRegal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Regaly_Nazev",
                table: "Regaly",
                column: "Nazev",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Regaly_Nazev",
                table: "Regaly");
        }
    }
}
