using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMovieLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMatrixMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("873dac8f-627c-44f3-a1d3-982817ca65c6"), "Keanu Reeves" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "GenreId", "PremiereDate", "Title" },
                values: new object[] { new Guid("9ed08e60-a2c6-425a-bf5d-0a1bd92ee83b"), new Guid("d09e5f41-9592-4c4c-a9ac-1a75d413b7ed"), new DateTime(1999, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" });

            migrationBuilder.InsertData(
                table: "MovieActor",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { new Guid("873dac8f-627c-44f3-a1d3-982817ca65c6"), new Guid("9ed08e60-a2c6-425a-bf5d-0a1bd92ee83b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("873dac8f-627c-44f3-a1d3-982817ca65c6"), new Guid("9ed08e60-a2c6-425a-bf5d-0a1bd92ee83b") });

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("873dac8f-627c-44f3-a1d3-982817ca65c6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9ed08e60-a2c6-425a-bf5d-0a1bd92ee83b"));
        }
    }
}
