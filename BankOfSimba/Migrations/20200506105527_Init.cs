using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BankOfSimba.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    AnimalType = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AnimalType", "Balance", "Name" },
                values: new object[,]
                {
                    { 1, "lion", 2000m, "Simba" },
                    { 2, "elephant", 5000m, "Hathi" },
                    { 3, "wolf", 6000m, "Akela" },
                    { 4, "bear", 1000m, "Balu" },
                    { 5, "snike", 500m, "Ka" },
                    { 6, "person", 500m, "King" },
                    { 7, "person", 500m, "Bad Guy" },
                    { 8, "person", 500m, "Good Guy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
