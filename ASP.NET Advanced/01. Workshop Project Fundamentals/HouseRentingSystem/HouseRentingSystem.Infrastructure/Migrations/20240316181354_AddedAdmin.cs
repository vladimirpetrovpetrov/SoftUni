using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AddedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d23c462f-74d3-4216-9675-829d159ef052", "AQAAAAEAACcQAAAAEIhf3g+GumtzSG6YQUnE/5N1qhW233m4CzZez8rGelroRpRi4TpSsqzkx2TKGKWH2g==", "91ee7665-587e-4116-a1af-194fdc43f7a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c5ae523-cdbb-41e4-b335-9bcad01d5264", "AQAAAAEAACcQAAAAEG5JyGBP5+KLJGJJQB+zRH1k8aDnf5OH8c3W56fs6E8irpfRpzSc2ffjyko08cnNHw==", "e70f8f11-41ae-4128-9eea-2ff3b39fe6b7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "773fa3ee-3713-4270-8bed-bade97d8fa27", "admin@mail.com", false, "Great", "Admin", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEN/rR9tC9dA7pFD8UvSPv4SW1j8HZUkoc7UskdNRxc2iHg0YUa/WgPV4GFwLzpfg4Q==", null, false, "4dc089ec-34e1-4be5-921b-e278abab5df8", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 8, "+359123456789", "bcb4f072-ecca-43c9-ab26-c060c6f364e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f16ced68-5fb8-42d6-b67e-b6ab9330429b", "AQAAAAEAACcQAAAAEIyKC6YnR9FQbiVVLCZH5khiNKOM9cGJ/TGr0P9VPeQggl1VLeEQcQ0KSP7SPiPfJQ==", "f2dce162-e139-4f6c-b084-793cc99e6e22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1912d202-1eb7-4fb5-8938-67f9f910b107", "AQAAAAEAACcQAAAAEPPEJ/r2FHCKR8/6rtTNq2m7IRe0dU7M1IGNAYR7knfi+qCKUHtBRWv3NCB1Niq7hQ==", "b5257201-53d0-42b2-83c7-a631bf7b2a72" });
        }
    }
}
