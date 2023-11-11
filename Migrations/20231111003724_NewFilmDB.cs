using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFilmRanking.Migrations
{
    /// <inheritdoc />
    public partial class NewFilmDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Budget",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Budget", "Director", "Genre" },
                values: new object[] { 25000000, "Frank Darabont", "prison drama film" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Budget", "Director", "Genre" },
                values: new object[] { 7200000, "Francis Ford Coppola", "epic crime film" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Budget", "Director", "Genre" },
                values: new object[] { 185000000, "Christopher Nolan", "superhero film" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Budget", "Director", "Genre" },
                values: new object[] { 22000000, "Steven Spielberg", "epic historical drama" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Budget", "Director", "Genre" },
                values: new object[] { 94000000, "Peter Jackson", "epic fantasy adventure film " });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Films");
        }
    }
}
