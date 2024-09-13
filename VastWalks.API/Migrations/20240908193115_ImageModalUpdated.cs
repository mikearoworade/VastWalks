using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VastWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class ImageModalUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileNamae",
                table: "Images",
                newName: "FileName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Images",
                newName: "FileNamae");
        }
    }
}
