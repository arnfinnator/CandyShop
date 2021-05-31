using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class AddingAttributes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Delicious Chocolate Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 3, "Pink Cherry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, false, false, "Fun Chocolate Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 2, "Pink Cherry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "IsInStock", "Name", "Price" },
                values: new object[] { true, "Fruit Ghost Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Fruit Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 2, "Assorted Berry Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, true, true, "Fruit Berry Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "IsInStock", "Name" },
                values: new object[] { 4, true, "Pink Gummy Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, true, true, "Delicious Gummy Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "IsInStock", "Name" },
                values: new object[] { true, "Delicious Gummy Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, true, "Delicious Berry Candy", 5.95m });

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
                columns: new[] { "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { false, true, "Assorted Cherry Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 3, true, "Fruit Ghost Candy", 5.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Pink Gummy Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Fruit Ghost Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, true, true, "Fruit Gummy Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 3, "Delicious Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "IsInStock", "Name", "Price" },
                values: new object[] { false, "Fun Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 3, "Fun Gummy Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Pink Gummy Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, false, false, "Fun Berry Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "IsInStock", "Name" },
                values: new object[] { 2, false, "Fruit Chocolate Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, false, false, "Fun Ghost Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "IsInStock", "Name" },
                values: new object[] { false, "Pink Ghost Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, false, "Assorted Strawberry Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 3, false, "Delicious Cherry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { true, false, "Pink Strawberry Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, false, "Fun Chocolate Candy", 2.95m });
        }
    }
}
