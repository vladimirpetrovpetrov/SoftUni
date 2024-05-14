using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestJWT.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateTimePropertyInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd25a8e6-a163-433d-8991-dbe1e0d3dd40", "AQAAAAIAAYagAAAAEGNEGaREm/yLiSG/iKePkIPSAOZ+sRMxDvb4MfNafQA0ohkNS8pCuEtt1c88lZgPOg==", "efe0b279-d6e4-4110-8ad0-306c3a70dee1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f34e39-e5c7-47e1-bcd9-590fbd1a668f", "AQAAAAIAAYagAAAAELkVnlS/dLFJAW4o1lnZgq4PSNAYmrqm9EQ49MX5JjMPUGBDq9iWMXZ7qZTaHtBAIA==", "f70b9852-3752-4025-bb01-4729196f3b92" });
        }
    }
}
