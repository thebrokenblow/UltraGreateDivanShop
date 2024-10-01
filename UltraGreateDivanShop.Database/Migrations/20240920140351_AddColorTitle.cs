using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraGreateDivanShop.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddColorTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorTitle",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorTitle",
                table: "Products");
        }
    }
}
