using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestJWT.Migrations
{
    /// <inheritdoc />
    public partial class fixAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00535050-d3db-47c6-a29f-64c26430a191",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef210b4c-f90b-47b0-8750-aeb9aa036264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b79ca8a6-1168-4484-b119-ff3bda5838b1", "AQAAAAIAAYagAAAAEDTKpHoAPBVSZfAofeRIo1dqqTZvwMAukFlHvLl7AOA9z4P+8GcoNI5lXvuPupeCfA==", "6b85b20e-3d25-4166-8475-861c6d91d997" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "430dfbfd-8294-43cc-ab8d-f2e036651349", "AQAAAAIAAYagAAAAEJ6E+TmpXSz0DLwAXF5jg4y4CBhy34HQqZDVFFAfYbpjrjdepv+Og6uVUJ5azQA/MA==", "839c1084-7c98-48d4-b464-28df9de5315c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00535050-d3db-47c6-a29f-64c26430a191",
                column: "NormalizedName",
                value: "ADMINISTRATOR");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef210b4c-f90b-47b0-8750-aeb9aa036264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b79a0940-929d-474c-ab4f-87176af019d8", "AQAAAAIAAYagAAAAEFaHTc8p5py4UiLDdcZXecQSBjZiQuJS26VCtfW70Dp/izmxSZCgLye3MVHm1IlNrw==", "7c5753fb-6f8f-46b1-86a2-7c4c2d1addca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b9741d-5b52-44fd-8ede-c1884f42a10c", "AQAAAAIAAYagAAAAEFZMW48FKKVoCQsLWuuA6eeS8grBLwZR1va/WyJp50Cyj40gGcrwl6cVpRmSf0C9pg==", "b6f0d2d5-ff07-4eb7-b476-ade3a68cbad9" });
        }
    }
}
