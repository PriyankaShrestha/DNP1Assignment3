using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class DeletePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonDB_FamiliesDB_Adult_FamilyCity_Adult_FamilyStreetName_Adult_FamilyHouseNumber_Adult_FamilyFloor",
                table: "PersonDB");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "PersonDB");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDB_JobDB_JobTitle",
                table: "PersonDB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonDB",
                table: "PersonDB");

            migrationBuilder.DropIndex(
                name: "IX_PersonDB_Adult_FamilyCity_Adult_FamilyStreetName_Adult_FamilyHouseNumber_Adult_FamilyFloor",
                table: "PersonDB");

            migrationBuilder.DropIndex(
                name: "IX_PersonDB_JobTitle",
                table: "PersonDB");

            migrationBuilder.DropColumn(
                name: "Adult_FamilyCity",
                table: "PersonDB");

            migrationBuilder.DropColumn(
                name: "Adult_FamilyFloor",
                table: "PersonDB");

            migrationBuilder.DropColumn(
                name: "Adult_FamilyHouseNumber",
                table: "PersonDB");

            migrationBuilder.DropColumn(
                name: "Adult_FamilyStreetName",
                table: "PersonDB");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PersonDB");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "PersonDB");

            migrationBuilder.RenameTable(
                name: "PersonDB",
                newName: "ChildrenDB");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "ChildrenDB",
                newName: "IX_ChildrenDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChildrenDB",
                table: "ChildrenDB",
                column: "CPRNumber");

            migrationBuilder.CreateTable(
                name: "AdultsDB",
                columns: table => new
                {
                    CPRNumber = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyCity = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyFloor = table.Column<string>(type: "TEXT", nullable: true),
                    FamilyHouseNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    FamilyStreetName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    HairColor = table.Column<string>(type: "TEXT", nullable: true),
                    EyeColor = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdultsDB", x => x.CPRNumber);
                    table.ForeignKey(
                        name: "FK_AdultsDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                        columns: x => new { x.FamilyCity, x.FamilyStreetName, x.FamilyHouseNumber, x.FamilyFloor },
                        principalTable: "FamiliesDB",
                        principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdultsDB_JobDB_JobTitle",
                        column: x => x.JobTitle,
                        principalTable: "JobDB",
                        principalColumn: "JobTitle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdultsDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "AdultsDB",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" });

            migrationBuilder.CreateIndex(
                name: "IX_AdultsDB_JobTitle",
                table: "AdultsDB",
                column: "JobTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_ChildrenDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "ChildrenDB",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildrenDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "ChildrenDB");

            migrationBuilder.DropTable(
                name: "AdultsDB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChildrenDB",
                table: "ChildrenDB");

            migrationBuilder.RenameTable(
                name: "ChildrenDB",
                newName: "PersonDB");

            migrationBuilder.RenameIndex(
                name: "IX_ChildrenDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "PersonDB",
                newName: "IX_PersonDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor");

            migrationBuilder.AddColumn<string>(
                name: "Adult_FamilyCity",
                table: "PersonDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adult_FamilyFloor",
                table: "PersonDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Adult_FamilyHouseNumber",
                table: "PersonDB",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adult_FamilyStreetName",
                table: "PersonDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PersonDB",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "PersonDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonDB",
                table: "PersonDB",
                column: "CPRNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDB_Adult_FamilyCity_Adult_FamilyStreetName_Adult_FamilyHouseNumber_Adult_FamilyFloor",
                table: "PersonDB",
                columns: new[] { "Adult_FamilyCity", "Adult_FamilyStreetName", "Adult_FamilyHouseNumber", "Adult_FamilyFloor" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonDB_JobTitle",
                table: "PersonDB",
                column: "JobTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDB_FamiliesDB_Adult_FamilyCity_Adult_FamilyStreetName_Adult_FamilyHouseNumber_Adult_FamilyFloor",
                table: "PersonDB",
                columns: new[] { "Adult_FamilyCity", "Adult_FamilyStreetName", "Adult_FamilyHouseNumber", "Adult_FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "PersonDB",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDB_JobDB_JobTitle",
                table: "PersonDB",
                column: "JobTitle",
                principalTable: "JobDB",
                principalColumn: "JobTitle",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
