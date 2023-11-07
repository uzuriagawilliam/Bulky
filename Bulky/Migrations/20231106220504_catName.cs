using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.Migrations
{
    /// <inheritdoc />
    public partial class catName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2de6ea60-b61c-451e-83d0-9e42baf6a351"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6f9a5e6-82c4-4f76-9d28-6ec069d21a31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4b89055-dd7d-4547-976f-4d10cfb395e7"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("243cc7fd-f859-44b3-9b8b-bb3f10a094e9"), 3, "Thriller" },
                    { new Guid("cd9e0baa-aa05-4edc-ba65-1d771ffffe35"), 2, "Drama" },
                    { new Guid("d17d7d98-583c-4f9a-ad26-2a8534e0e77e"), 1, "Action" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("243cc7fd-f859-44b3-9b8b-bb3f10a094e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd9e0baa-aa05-4edc-ba65-1d771ffffe35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d17d7d98-583c-4f9a-ad26-2a8534e0e77e"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("2de6ea60-b61c-451e-83d0-9e42baf6a351"), 1, "Action" },
                    { new Guid("b6f9a5e6-82c4-4f76-9d28-6ec069d21a31"), 2, "Action" },
                    { new Guid("e4b89055-dd7d-4547-976f-4d10cfb395e7"), 3, "Action" }
                });
        }
    }
}
