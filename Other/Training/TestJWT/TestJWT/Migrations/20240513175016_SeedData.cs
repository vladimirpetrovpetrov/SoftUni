using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestJWT.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolesPermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesPermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolesPermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44a539b2-223a-4c1b-9d1c-954ef8d889ff", "eb8f0668-2e21-4903-81a3-b858513bb59c", "LevelOne", "LEVELONE" },
                    { "77af610e-3202-4bea-8d5c-c20c07f7effe", "3882b86e-4ce3-49e6-83a1-a0294c57a8ff", "LevelThree", "LEVELTHREE" },
                    { "dc3cf4ec-f90c-4915-b749-4ab01863fdf6", "1c72eeac-aa45-4a8e-8606-6bbd1dca9a73", "LevelTwo", "LEVELTWO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3", 0, "022fef6a-5d1e-4eb4-9e86-983b8361098f", "levelOne@gmail.com", true, false, null, "LEVELONE@GMAIL.COM", "LEVELONE@GMAIL.COM", "AQAAAAIAAYagAAAAEBnQT2UVM0i5tLu9k2FwXk35cBkniHlNbbbvxN+c5oMgydxa6WgJhn21cH26dGxs0A==", null, false, "b5053a86-d862-44dd-8e69-401667367925", false, "levelOne@gmail.com" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CreateZone" },
                    { 2, "ReadZone" },
                    { 3, "UpdateZone" },
                    { 4, "DeleteZone" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44a539b2-223a-4c1b-9d1c-954ef8d889ff", "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3" });

            migrationBuilder.InsertData(
                table: "RolesPermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 2, "44a539b2-223a-4c1b-9d1c-954ef8d889ff" },
                    { 1, "77af610e-3202-4bea-8d5c-c20c07f7effe" },
                    { 2, "77af610e-3202-4bea-8d5c-c20c07f7effe" },
                    { 3, "77af610e-3202-4bea-8d5c-c20c07f7effe" },
                    { 4, "77af610e-3202-4bea-8d5c-c20c07f7effe" },
                    { 1, "dc3cf4ec-f90c-4915-b749-4ab01863fdf6" },
                    { 2, "dc3cf4ec-f90c-4915-b749-4ab01863fdf6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolesPermissions_PermissionId",
                table: "RolesPermissions",
                column: "PermissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolesPermissions");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77af610e-3202-4bea-8d5c-c20c07f7effe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc3cf4ec-f90c-4915-b749-4ab01863fdf6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44a539b2-223a-4c1b-9d1c-954ef8d889ff", "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44a539b2-223a-4c1b-9d1c-954ef8d889ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3");
        }
    }
}
