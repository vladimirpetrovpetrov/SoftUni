using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftUniBazar.Data.Migrations
{
    public partial class CreatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ads",
                type: "int",
                nullable: false,
                comment: "Advertisement identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Ad identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Ads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Advertisement category identifier");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Advertisement date and time of creation");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ads",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                comment: "Advertisement description");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Advertisement URL of the image");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ads",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                comment: "Advertisement name");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Ads",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Advertisement owner identifier");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Ads",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                comment: "Advertisement price");

            migrationBuilder.CreateTable(
                name: "AdsBuyers",
                columns: table => new
                {
                    BuyerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Identifier of the buyer of the advertisement."),
                    AdId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of the advertisement being bought.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdsBuyers", x => new { x.BuyerId, x.AdId });
                    table.ForeignKey(
                        name: "FK_AdsBuyers_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdsBuyers_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Category of an Advertisement");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_CategoryId",
                table: "Ads",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_OwnerId",
                table: "Ads",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AdsBuyers_AdId",
                table: "AdsBuyers",
                column: "AdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_AspNetUsers_OwnerId",
                table: "Ads",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Categories_CategoryId",
                table: "Ads",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_AspNetUsers_OwnerId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Categories_CategoryId",
                table: "Ads");

            migrationBuilder.DropTable(
                name: "AdsBuyers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Ads_CategoryId",
                table: "Ads");

            migrationBuilder.DropIndex(
                name: "IX_Ads_OwnerId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ads");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ads",
                type: "int",
                nullable: false,
                comment: "Ad identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Advertisement identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
