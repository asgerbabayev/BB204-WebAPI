using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2.Migrations
{
    public partial class updateDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "18b22b9e-0ab6-4365-b843-8c603bf88e5b");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FriendId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50c80de5-e382-42f7-87a6-ec12d99305f8", 0, "4a87d1e7-5e30-4223-857b-d8802a76329b", "sitare@code.edu.az", false, "18b22b9e-0ab6-4365-b843-8c603bf88e5b", false, null, null, null, null, null, false, "6ddf8edc-3f08-4e3e-8e5c-60d8718223a9", false, "sitare" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FriendId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b57851a6-fd3d-41ee-9ac6-2a09f096feef", 0, "3f35c68f-c555-450c-a2c2-3282fbb80b7f", "nergiz@code.edu.az", false, "18b22b9e-0ab6-4365-b843-8c603bf88e5b", false, null, null, null, null, null, false, "5bb4c405-0777-43a8-91cc-339b1b67f2ff", false, "nergiz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "50c80de5-e382-42f7-87a6-ec12d99305f8");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "b57851a6-fd3d-41ee-9ac6-2a09f096feef");

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FriendId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18b22b9e-0ab6-4365-b843-8c603bf88e5b", 0, "c01afed4-3a91-4072-9395-7c29ac9c3533", "sitare@code.edu.az", false, null, false, null, null, null, null, null, false, "f5ed48da-21c9-4e15-81a7-66756001626d", false, "aysel" });
        }
    }
}
