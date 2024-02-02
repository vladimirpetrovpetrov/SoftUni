using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoList.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TaskSeedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Deadline", "Description", "IsCompleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 4, 23, 4, 11, 98, DateTimeKind.Local).AddTicks(1167), "To write something interesting.", false, "Write first task" },
                    { 2, new DateTime(2024, 2, 4, 23, 4, 11, 98, DateTimeKind.Local).AddTicks(1210), "To write something interesting.", false, "Write second task" },
                    { 3, new DateTime(2024, 2, 4, 23, 4, 11, 98, DateTimeKind.Local).AddTicks(1212), "To write something interesting.", false, "Write third task" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
