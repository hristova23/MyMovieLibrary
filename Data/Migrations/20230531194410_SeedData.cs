using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyMovieLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"), "Ethan Hawke" },
                    { new Guid("409512bc-bf31-4a6e-ba0d-13a052a51109"), "Dwayne Johnson" },
                    { new Guid("79d8a005-9662-4c48-8e1a-89c3e163c6dd"), "Michael Fassbender" },
                    { new Guid("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"), "Noah Taylor" },
                    { new Guid("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"), "Sarah Snook" },
                    { new Guid("ee4498a8-2251-402e-8ce0-070807f960c9"), "Sarah Shahi" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02ec846d-5f9c-4b31-b17f-413f0b49493b"), "Horror" },
                    { new Guid("278b2b4e-e0d7-45cb-93ed-6d38489922a7"), "Crime" },
                    { new Guid("3104db1a-525c-4f63-aedf-242184ee6637"), "Comedy" },
                    { new Guid("6d7b3135-dd01-4dc1-8cb2-c0631f66bdf0"), "Action" },
                    { new Guid("9e315f6b-b49c-4596-9154-f9011715b25b"), "Thriller" },
                    { new Guid("b451328c-8f3c-4511-94c2-29f2e3402eb6"), "Fantasy" },
                    { new Guid("c8324202-a9bf-4d8e-a0ce-c21a046c8a52"), "Drama" },
                    { new Guid("cd501ea6-cf55-4382-807e-4037599647b3"), "Adventure" },
                    { new Guid("d09e5f41-9592-4c4c-a9ac-1a75d413b7ed"), "Science Fiction" },
                    { new Guid("d4da5470-0224-4efc-9fe2-5cc2747630f2"), "Romance" },
                    { new Guid("e789f0b0-219e-4632-9d0e-d41233ed72f5"), "Biographical" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "GenreId", "PremiereDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1a4d6444-4739-4058-a905-ba58f9c43779"), new Guid("cd501ea6-cf55-4382-807e-4037599647b3"), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Adam" },
                    { new Guid("6c105a1c-011b-4605-bc7e-6e12eb470338"), new Guid("c8324202-a9bf-4d8e-a0ce-c21a046c8a52"), new DateTime(2015, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steve Jobs" },
                    { new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc"), new Guid("d09e5f41-9592-4c4c-a9ac-1a75d413b7ed"), new DateTime(2015, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Predestination" },
                    { new Guid("b38f029e-018f-40e7-830d-958e7a658fe0"), new Guid("6d7b3135-dd01-4dc1-8cb2-c0631f66bdf0"), new DateTime(2018, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skyscraper" },
                    { new Guid("e1e820f4-a38d-41c3-b87f-accc0eaa5672"), new Guid("3104db1a-525c-4f63-aedf-242184ee6637"), new DateTime(2017, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baywatch" },
                    { new Guid("f1a9a5d1-aa68-4cba-979a-817cc502ca99"), new Guid("02ec846d-5f9c-4b31-b17f-413f0b49493b"), new DateTime(2013, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Purge" }
                });

            migrationBuilder.InsertData(
                table: "MovieActor",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("409512bc-bf31-4a6e-ba0d-13a052a51109"), new Guid("1a4d6444-4739-4058-a905-ba58f9c43779") },
                    { new Guid("ee4498a8-2251-402e-8ce0-070807f960c9"), new Guid("1a4d6444-4739-4058-a905-ba58f9c43779") },
                    { new Guid("79d8a005-9662-4c48-8e1a-89c3e163c6dd"), new Guid("6c105a1c-011b-4605-bc7e-6e12eb470338") },
                    { new Guid("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"), new Guid("6c105a1c-011b-4605-bc7e-6e12eb470338") },
                    { new Guid("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"), new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc") },
                    { new Guid("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"), new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc") },
                    { new Guid("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"), new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc") },
                    { new Guid("409512bc-bf31-4a6e-ba0d-13a052a51109"), new Guid("b38f029e-018f-40e7-830d-958e7a658fe0") },
                    { new Guid("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"), new Guid("b38f029e-018f-40e7-830d-958e7a658fe0") },
                    { new Guid("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"), new Guid("f1a9a5d1-aa68-4cba-979a-817cc502ca99") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("278b2b4e-e0d7-45cb-93ed-6d38489922a7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9e315f6b-b49c-4596-9154-f9011715b25b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b451328c-8f3c-4511-94c2-29f2e3402eb6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d4da5470-0224-4efc-9fe2-5cc2747630f2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e789f0b0-219e-4632-9d0e-d41233ed72f5"));

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("409512bc-bf31-4a6e-ba0d-13a052a51109"), new Guid("1a4d6444-4739-4058-a905-ba58f9c43779") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("ee4498a8-2251-402e-8ce0-070807f960c9"), new Guid("1a4d6444-4739-4058-a905-ba58f9c43779") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("79d8a005-9662-4c48-8e1a-89c3e163c6dd"), new Guid("6c105a1c-011b-4605-bc7e-6e12eb470338") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"), new Guid("6c105a1c-011b-4605-bc7e-6e12eb470338") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"), new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"), new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"), new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("409512bc-bf31-4a6e-ba0d-13a052a51109"), new Guid("b38f029e-018f-40e7-830d-958e7a658fe0") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"), new Guid("b38f029e-018f-40e7-830d-958e7a658fe0") });

            migrationBuilder.DeleteData(
                table: "MovieActor",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"), new Guid("f1a9a5d1-aa68-4cba-979a-817cc502ca99") });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e1e820f4-a38d-41c3-b87f-accc0eaa5672"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("21371c7e-3ab9-4dcc-8f53-51c8eef910ed"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("409512bc-bf31-4a6e-ba0d-13a052a51109"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("79d8a005-9662-4c48-8e1a-89c3e163c6dd"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("a783e8fc-55c1-4ec3-ae4f-6ddec38e6d8d"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("ba3af6d3-cf1e-4348-a832-cbbf083c8cfc"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("ee4498a8-2251-402e-8ce0-070807f960c9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3104db1a-525c-4f63-aedf-242184ee6637"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1a4d6444-4739-4058-a905-ba58f9c43779"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6c105a1c-011b-4605-bc7e-6e12eb470338"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7dca29e5-2322-4453-b303-768cf8d1e6bc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b38f029e-018f-40e7-830d-958e7a658fe0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f1a9a5d1-aa68-4cba-979a-817cc502ca99"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("02ec846d-5f9c-4b31-b17f-413f0b49493b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6d7b3135-dd01-4dc1-8cb2-c0631f66bdf0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c8324202-a9bf-4d8e-a0ce-c21a046c8a52"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cd501ea6-cf55-4382-807e-4037599647b3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d09e5f41-9592-4c4c-a9ac-1a75d413b7ed"));
        }
    }
}
