using Microsoft.EntityFrameworkCore.Migrations;

namespace Practices.Migrations
{
    public partial class JWTPracticesDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    HashedPassword = table.Column<string>(nullable: true),
                    InvalidLoginAttemptsAmount = table.Column<int>(nullable: false),
                    IsBlocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toy",
                columns: new[] { "Id", "Manufacturer", "Name", "Price" },
                columns: new[] { "Id", "Manufacturer", "Name", "Price" },
                values: new object[] { 1, "uhAjidosk", "jdad", 100 });

            migrationBuilder.InsertData(
                table: "Toy",
                columns: new[] { "Id", "Manufacturer", "Name", "Price" },
                values: new object[] { 2, "g9sdjfks", " wejr029", 50 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "HashedPassword", "InvalidLoginAttemptsAmount", "IsBlocked", "Username" },
                values: new object[] { 1, "A616A64C0FBC30F12287D0F24F3B90DD2E6A206E", 0, false, "Shotiko" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toy");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
