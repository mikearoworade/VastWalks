using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VastWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesTableUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Images",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Images",
                newName: "id");
        }
    }
}
