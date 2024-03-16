using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AddedUserColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f16ced68-5fb8-42d6-b67e-b6ab9330429b", "Teodor", "Lesly", "AQAAAAEAACcQAAAAEIyKC6YnR9FQbiVVLCZH5khiNKOM9cGJ/TGr0P9VPeQggl1VLeEQcQ0KSP7SPiPfJQ==", "f2dce162-e139-4f6c-b084-793cc99e6e22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1912d202-1eb7-4fb5-8938-67f9f910b107", "Linda", "Michaels", "AQAAAAEAACcQAAAAEPPEJ/r2FHCKR8/6rtTNq2m7IRe0dU7M1IGNAYR7knfi+qCKUHtBRWv3NCB1Niq7hQ==", "b5257201-53d0-42b2-83c7-a631bf7b2a72" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a94d397-421c-4ef7-a02d-0282e41c5523", "AQAAAAEAACcQAAAAEM2pIKPZxcsbdQURaxvgdZHEmoHpB9joTpjDYK4wKPrIohzJAzobqxghdVFZcIyY6g==", "f136a6f9-d934-427c-978e-01ff8bb85ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02af2b70-fc68-4bce-982e-de700b4084cd", "AQAAAAEAACcQAAAAEJwFOUNez4g2AYIOIXjnH8Pu79pUk2GtH2gER0n0Ka5n1gofynacc+JKXsg3BebKqg==", "3917af84-219c-4d02-adef-3707ba93a711" });
        }
    }
}
