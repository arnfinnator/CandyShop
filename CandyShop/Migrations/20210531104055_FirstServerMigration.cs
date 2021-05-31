using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class FirstServerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 3, false, "Assorted Chocolate Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "IsInStock", "Price" },
                values: new object[] { 1, true, 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, true, "Fun Strawberry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, false, "Fruit Chocolate Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 1, "Fruit Gummy Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name" },
                values: new object[] { 3, true, false, "Fun Strawberry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "IsInStock", "Name" },
                values: new object[] { false, "Assorted Chocolate Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Fun Chocolate Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 2, "Assorted Strawberry Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                column: "Name",
                value: "Fruit Strawberry Candy");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Fruit Gummy Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "IsInStock", "Name", "Price" },
                values: new object[] { true, "Pink Ghost Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 2, false, "Fruit Berry Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "CategoryId", "IsInStock", "Name" },
                values: new object[] { 4, true, "Delicious Chocolate Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Fun Strawberry Candy", 3.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 2, true, "Delicious Chocolate Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "IsInStock", "Price" },
                values: new object[] { 3, false, 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, false, "Fun Chocolate Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, true, "Pink Cherry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Fruit Ghost Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name" },
                values: new object[] { 4, false, true, "Fruit Gummy Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "IsInStock", "Name" },
                values: new object[] { true, "Assorted Berry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 2, "Fruit Berry Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Pink Gummy Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                column: "Name",
                value: "Delicious Gummy Candy");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Delicious Gummy Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "IsInStock", "Name", "Price" },
                values: new object[] { false, "Delicious Berry Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, true, "Fun Strawberry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "CategoryId", "IsInStock", "Name" },
                values: new object[] { 1, false, "Assorted Cherry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Fruit Ghost Candy", 5.95m });
        }
    }
}
