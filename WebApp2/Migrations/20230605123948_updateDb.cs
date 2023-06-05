using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Friends_AppUserId",
                table: "Friends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.RenameTable(
                name: "Friends",
                newName: "AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_Friends_AppUserId",
                table: "AppUser",
                newName: "IX_AppUser_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AppUser_AppUserId",
                table: "AppUser",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AppUser_AppUserId",
                table: "AppUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "Friends");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_AppUserId",
                table: "Friends",
                newName: "IX_Friends_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Friends_AppUserId",
                table: "Friends",
                column: "AppUserId",
                principalTable: "Friends",
                principalColumn: "Id");
        }
    }
}
