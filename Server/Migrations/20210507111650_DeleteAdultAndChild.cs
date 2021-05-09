using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class DeleteAdultAndChild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdultsDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "AdultsDB");

            migrationBuilder.DropForeignKey(
                name: "FK_AdultsDB_JobDB_JobTitle",
                table: "AdultsDB");

            migrationBuilder.DropForeignKey(
                name: "FK_ChildrenDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "ChildrenDB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobDB",
                table: "JobDB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChildrenDB",
                table: "ChildrenDB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdultsDB",
                table: "AdultsDB");

            migrationBuilder.RenameTable(
                name: "JobDB",
                newName: "Job");

            migrationBuilder.RenameTable(
                name: "ChildrenDB",
                newName: "Child");

            migrationBuilder.RenameTable(
                name: "AdultsDB",
                newName: "Adult");

            migrationBuilder.RenameIndex(
                name: "IX_ChildrenDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "Child",
                newName: "IX_Child_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor");

            migrationBuilder.RenameIndex(
                name: "IX_AdultsDB_JobTitle",
                table: "Adult",
                newName: "IX_Adult_JobTitle");

            migrationBuilder.RenameIndex(
                name: "IX_AdultsDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "Adult",
                newName: "IX_Adult_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Job",
                column: "JobTitle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Child",
                table: "Child",
                column: "CPRNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adult",
                table: "Adult",
                column: "CPRNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Adult_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "Adult",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adult_Job_JobTitle",
                table: "Adult",
                column: "JobTitle",
                principalTable: "Job",
                principalColumn: "JobTitle",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "Child",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adult_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "Adult");

            migrationBuilder.DropForeignKey(
                name: "FK_Adult_Job_JobTitle",
                table: "Adult");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "Child");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Child",
                table: "Child");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adult",
                table: "Adult");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "JobDB");

            migrationBuilder.RenameTable(
                name: "Child",
                newName: "ChildrenDB");

            migrationBuilder.RenameTable(
                name: "Adult",
                newName: "AdultsDB");

            migrationBuilder.RenameIndex(
                name: "IX_Child_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "ChildrenDB",
                newName: "IX_ChildrenDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor");

            migrationBuilder.RenameIndex(
                name: "IX_Adult_JobTitle",
                table: "AdultsDB",
                newName: "IX_AdultsDB_JobTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Adult_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "AdultsDB",
                newName: "IX_AdultsDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobDB",
                table: "JobDB",
                column: "JobTitle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChildrenDB",
                table: "ChildrenDB",
                column: "CPRNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdultsDB",
                table: "AdultsDB",
                column: "CPRNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_AdultsDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "AdultsDB",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdultsDB_JobDB_JobTitle",
                table: "AdultsDB",
                column: "JobTitle",
                principalTable: "JobDB",
                principalColumn: "JobTitle",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildrenDB_FamiliesDB_FamilyCity_FamilyStreetName_FamilyHouseNumber_FamilyFloor",
                table: "ChildrenDB",
                columns: new[] { "FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor" },
                principalTable: "FamiliesDB",
                principalColumns: new[] { "City", "StreetName", "HouseNumber", "Floor" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
