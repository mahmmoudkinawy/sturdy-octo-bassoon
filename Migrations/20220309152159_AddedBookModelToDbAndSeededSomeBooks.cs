using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListRazor.Migrations
{
    public partial class AddedBookModelToDbAndSeededSomeBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "Name" },
                values: new object[] { 1, "Kinawy", "C# 10" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "Name" },
                values: new object[] { 2, "Kino", "Asp.net Core" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
