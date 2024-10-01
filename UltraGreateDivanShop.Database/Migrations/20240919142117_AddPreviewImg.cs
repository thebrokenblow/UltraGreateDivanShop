using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraGreateDivanShop.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddPreviewImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreviewImg",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreviewImg",
                table: "Products");
        }
    }
}
