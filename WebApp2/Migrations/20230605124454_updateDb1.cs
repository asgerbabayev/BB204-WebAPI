using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2.Migrations
{
    public partial class updateDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AppUser_AppUserId",
                table: "AppUser");

            migrationBuilder.DropIndex(
                name: "IX_AppUser_AppUserId",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "AppUser");

            migrationBuilder.AlterColumn<string>(
                name: "FriendId",
                table: "AppUser",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_FriendId",
                table: "AppUser",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AppUser_FriendId",
                table: "AppUser",
                column: "FriendId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_AppUser_FriendId",
                table: "AppUser");

            migrationBuilder.DropIndex(
                name: "IX_AppUser_FriendId",
                table: "AppUser");

            migrationBuilder.AlterColumn<int>(
                name: "FriendId",
                table: "AppUser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "AppUser",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_AppUserId",
                table: "AppUser",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_AppUser_AppUserId",
                table: "AppUser",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "Id");
        }
    }
}
