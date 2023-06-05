using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2.Migrations
{
    public partial class updateDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FriendId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18b22b9e-0ab6-4365-b843-8c603bf88e5b", 0, "c01afed4-3a91-4072-9395-7c29ac9c3533", "sitare@code.edu.az", false, null, false, null, null, null, null, null, false, "f5ed48da-21c9-4e15-81a7-66756001626d", false, "aysel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "18b22b9e-0ab6-4365-b843-8c603bf88e5b");
        }
    }
}
