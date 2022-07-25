using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_API_TEMPLATE.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "Name" },
                values: new object[] { new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"), new DateTime(1952, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walter Isaacson" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "Name" },
                values: new object[] { new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.K. Rowling" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Genre", "ISBN", "Publisher", "Rating", "ReleaseDate", "Subtitle", "Title" },
                values: new object[] { new Guid("150c81c6-2458-466e-907a-2df11325e2b8"), new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"), "Walter Isaacson’s “enthralling” (The New Yorker) worldwide bestselling biography of Apple cofounder Steve Jobs.", 25, "978-1451648539", "Simon & Schuster; 1st edition (October 24, 2011)", 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Steve Jobs" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Genre", "ISBN", "Publisher", "Rating", "ReleaseDate", "Subtitle", "Title" },
                values: new object[] { new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"), new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs.", 0, "978-0439708180", "Scholastic; 1st Scholastic Td Ppbk Print., Sept.1999 edition (September 1, 1998)", 5.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Harry Potter and the Sorcerer's Stone" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Genre", "ISBN", "Publisher", "Rating", "ReleaseDate", "Subtitle", "Title" },
                values: new object[] { new Guid("bfe902af-3cf0-4a1c-8a83-66be60b028ba"), new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"), "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. ", 0, "978-0439064873", "Scholastic Paperbacks; Reprint edition (September 1, 2000)", 5.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Harry Potter and the Chamber of Secrets" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
