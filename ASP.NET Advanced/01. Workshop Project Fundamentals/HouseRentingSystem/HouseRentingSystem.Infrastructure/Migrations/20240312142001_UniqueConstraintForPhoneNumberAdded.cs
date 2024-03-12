using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79077a97-e103-4e58-af0b-565fbbe32f8f", "AQAAAAEAACcQAAAAEGoPlNy6SvM7nLYFRFf9snJLsaHirE4R4d4x4KjbXESDsKZuIT+hj6wn3oxfq0CJjw==", "2068cf94-fc44-43ed-b22e-936397c90587" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f08278-31e6-4c30-b9ec-1d48272b3f77", "AQAAAAEAACcQAAAAELhy571vnuh2GwKQFA4BXaEiTa1VgQ7ID9shKx0Q5BA5F0cM8V415pfehjLrNxH+iw==", "133b0afa-79fb-478c-838c-0268bcfb6e86" });
        }
    }
}
