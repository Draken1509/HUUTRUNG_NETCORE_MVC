using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HUUTRUNG.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCategoryCharacterComicType_ComicSeriesAlignmentAndFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseOfOperations = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeComics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeComics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colorist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Price50 = table.Column<double>(type: "float", nullable: true),
                    Price100 = table.Column<double>(type: "float", nullable: true),
                    OnSaleDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PageCount = table.Column<int>(type: "int", nullable: true),
                    Rated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFree = table.Column<bool>(type: "bit", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeComicId = table.Column<int>(type: "int", nullable: true),
                    SeriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comics_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comics_TypeComics_TypeComicId",
                        column: x => x.TypeComicId,
                        principalTable: "TypeComics",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Alignment",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BIRDS OF PREY " },
                    { 2, "BATGIRL " }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Graphic Novel" },
                    { 2, 2, "Comic Book" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Alias", "BaseOfOperations", "Created_at", "Description", "FirstAppearance", "Name", "Occupation", "Power", "Thumbnail", "Updated_at" },
                values: new object[,]
                {
                    { 1, "Wonder woman", "Chiu", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.", "abc", "Action Novel", "abc", "super metal", "hehe.jpg", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "Wonder woman", "Chiu", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.", "abc", "Action Novel", "abc", "super metal", "hehe.jpg", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "Wonder woman", "Chiu", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.", "abc", "Action Novel", "abc", "super metal", "hehe.jpg", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, "Wonder woman", "Chiu", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.", "abc", "Action Novel", "abc", "super metal", "hehe.jpg", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, "Wonder woman", "Chiu", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hal Jordan’s life was changed twice by crashing aircraft. The first time was when he witnessed the death of his father, pilot Martin Jordan. The second was when, as an adult and trained pilot himself, he was summoned to the crashed wreckage of a spaceship belonging to an alien named Abin Sur. Abin explained that he was a member of the Green Lantern Corps, an organization of beings from across the cosmos, armed with power rings fueled by the green energy of all willpower in the universe. Upon his death, Abin entrusted his ring and duties as the Green Lantern of Earth’s space sector to Hal Jordan.", "abc", "Action Novel", "abc", "super metal", "hehe.jpg", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "heheh", "BATMAN & ROBIN: YEAR ONE NOIR EDITION " },
                    { 2, "heheh", "BATGIRL " },
                    { 3, "heheh", "DC VS VAMPRIES: WORLD WAR " }
                });

            migrationBuilder.InsertData(
                table: "TypeComics",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "heheh", 1, "Graphic Novel" },
                    { 2, "heheh", 2, "Comic Book" }
                });

            migrationBuilder.InsertData(
                table: "Comics",
                columns: new[] { "Id", "ArtBy", "Colorist", "Cover", "Created_at", "Description", "IsFree", "IsNew", "Name", "OnSaleDate", "PageCount", "Price", "Price100", "Price50", "Rated", "SeriesId", "Thumbnail", "TypeComicId", "Updated_at", "Writer" },
                values: new object[,]
                {
                    { 1, "Nick Dragotta", "Frank Martin", "Frank Martin, Nick Dragotta", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.", true, false, "ABSOLUTE BATMAN NOIR EDITION #1 ", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3.5, null, null, "Teen", 1, "hehe.jpg", 1, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Scott Snyder" },
                    { 2, "Nick Dragotta", "Frank Martin", "Frank Martin, Nick Dragotta", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.", false, false, "ABSOLUTE BATMAN NOIR EDITION #1 ", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3.5, null, null, "Teen", 2, "hehe.jpg", 2, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Scott Snyder" },
                    { 3, "Nick Dragotta", "Frank Martin", "Frank Martin, Nick Dragotta", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Without the mansion…without the money…without the butler…what’s left is the Absolute Dark Knight! Noir Edition.", true, false, "ABSOLUTE BATMAN NOIR EDITION #1 ", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3.5, null, null, "Teen", 1, "hehe.jpg", 2, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "Scott Snyder" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comics_SeriesId",
                table: "Comics",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Comics_TypeComicId",
                table: "Comics",
                column: "TypeComicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alignment");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "TypeComics");
        }
    }
}
