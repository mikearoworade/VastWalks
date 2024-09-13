using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VastWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedRegionAndDiffultyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0fcaf011-371e-48a9-8280-1caca3c9a624"), "Medium" },
                    { new Guid("25355da1-b203-470e-9672-cf185af83ada"), "Easy" },
                    { new Guid("d908a688-b24c-4f0b-80d8-19376f21e0f4"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("57b9bd28-ce6d-435b-b430-93d72fe2b97e"), "BOP", "Bay Of Plenty", null },
                    { new Guid("7646a62b-fcf5-4dcf-b494-75a15185c33f"), "STL", "Southland", null },
                    { new Guid("81edc90b-3630-4618-993f-62d31bba15eb"), "NTL", "Northland", null },
                    { new Guid("cfc5729e-7028-47c6-8808-db2221840f76"), "AKL", "Auckland", null },
                    { new Guid("f07a94a9-1953-42b5-b104-eb5d3868ab9a"), "WGN", "Wellington", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("0fcaf011-371e-48a9-8280-1caca3c9a624"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("25355da1-b203-470e-9672-cf185af83ada"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("d908a688-b24c-4f0b-80d8-19376f21e0f4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("57b9bd28-ce6d-435b-b430-93d72fe2b97e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7646a62b-fcf5-4dcf-b494-75a15185c33f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("81edc90b-3630-4618-993f-62d31bba15eb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfc5729e-7028-47c6-8808-db2221840f76"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f07a94a9-1953-42b5-b104-eb5d3868ab9a"));
        }
    }
}
