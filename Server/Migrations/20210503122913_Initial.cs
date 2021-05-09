using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FamiliesDB",
                columns: table => new
                {
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Floor = table.Column<string>(type: "TEXT", nullable: false),
                    StreetName = table.Column<string>(type: "TEXT", nullable: false),
                    HouseNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamiliesDB", x => new { x.City, x.StreetName, x.HouseNumber, x.Floor });
                });

            migrationBuilder.CreateTable(
                name: "JobDB",
                columns: table => new
                {
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Salary = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDB", x => x.JobTitle);
                });

            migrationBuilder.CreateTable(
                name: "UsersDB",
                columns: table => new
                {
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDB", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "PersonDB",
                columns: table => new
                {
                    CPRNumber = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    HairColor = table.Column<string>(type: "TEXT", nullable: true),
                    EyeColor = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Adult_FamilyCity = table.Column<string>(type: "TEXT", nullable: true),
                    Adult_FamilyFloor = table.Column<string>(type: "TEXT", nullable: true),
                    Adult_FamilyHouseNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    Adult_FamilyStreetName = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyCity = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyFloor = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyHouseNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FamilyStreetName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDB", x => x.CPRNumber);
                    table.ForeignKey(
                        name: "FK_PersonDB_FamiliesDB_Adult_FamilyCity_Adult_FamilyStreetName_Adult_FamilyHouseNumber_Adult_FamilyFloor",
                        columns: x => new { x.Adult_FamilyCity, x.Adult_FamilyStreetName, x.Adult_FamilyHouseNumber, x.Adult_FamilyFloor },
                        principalTable: "FamiliesDB",
                        principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                        columns: x => new { x.FamilyCity, x.FamilyStreetName, x.FamilyHouseNumber, x.FamilyFloor },
                        principalTable: "FamiliesDB",
                        principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonDB_JobDB_JobTitle",
                        column: x => x.JobTitle,
                        principalTable: "JobDB",
                        principalColumn: "JobTitle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonDB_Adult_FamilyCity_Adult_FamilyStreetName_Adult_FamilyHouseNumber_Adult_FamilyFloor",
                table: "PersonDB",
                columns: new[] { "Adult_FamilyCity", "Adult_FamilyStreetName", "Adult_FamilyHouseNumber", "Adult_FamilyFloor" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "PersonDB",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonDB_JobTitle",
                table: "PersonDB",
                column: "JobTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonDB");

            migrationBuilder.DropTable(
                name: "UsersDB");

            migrationBuilder.DropTable(
                name: "FamiliesDB");

            migrationBuilder.DropTable(
                name: "JobDB");
        }
    }
}
