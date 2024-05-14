using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestJWT.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    InProgress = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f34e39-e5c7-47e1-bcd9-590fbd1a668f", "AQAAAAIAAYagAAAAELkVnlS/dLFJAW4o1lnZgq4PSNAYmrqm9EQ49MX5JjMPUGBDq9iWMXZ7qZTaHtBAIA==", "f70b9852-3752-4025-bb01-4729196f3b92" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "022fef6a-5d1e-4eb4-9e86-983b8361098f", "AQAAAAIAAYagAAAAEBnQT2UVM0i5tLu9k2FwXk35cBkniHlNbbbvxN+c5oMgydxa6WgJhn21cH26dGxs0A==", "b5053a86-d862-44dd-8e69-401667367925" });
        }
    }
}
