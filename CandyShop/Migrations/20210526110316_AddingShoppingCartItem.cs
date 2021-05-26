using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandyId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Candies_CandyId",
                        column: x => x.CandyId,
                        principalTable: "Candies",
                        principalColumn: "CandyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\chocolateCandy-small.jpg", "\\images\\chocolateCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 2, "\\Images\\FruitCandy.jpg", false, "Delicious Strawberry Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 3, "\\Images\\FruitCandy2.jpg", true, "Fun Strawberry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 3, "\\Images\\FruitCandy3.jpg", true, "Pink Strawberry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, "\\Images\\chocolateCandy.jpg", true, "Fruit Strawberry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "\\Images\\chocolateCandy2.jpg", "Delicious Chocolate Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { "\\Images\\chocolateCandy3.jpg", true, "Fun Berry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 3, "\\Images\\fruitCandy.jpg", false, "Assorted Cherry Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, "\\Images\\fruitCandy2.jpg", false, false, "Delicious Cherry Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name" },
                values: new object[] { 1, "\\Images\\fruitCandy3.jpg", true, "Pink Gummy Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { "\\Images\\gummyCandy.jpg", false, "Pink Gummy Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, "\\Images\\gummyCandy2.jpg", false, true, "Assorted Cherry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name" },
                values: new object[] { 2, "\\Images\\gummyCandy3.jpg", true, "Pink Ghost Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "ImageUrl", "Name", "Price" },
                values: new object[] { 4, "\\Images\\hardCandy.jpg", "Pink Strawberry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "CategoryId", "ImageUrl", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, "\\Images\\hardCandy2.jpg", true, "Fruit Berry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, "\\Images\\hardCandy3.jpg", true, false, "Fruit Strawberry Candy", 3.95m });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CandyId",
                table: "ShoppingCartItems",
                column: "CandyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\chocolateCandy-small.jpg", "~\\images\\chocolateCandy.jpg" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 3, "~\\Images\\FruitCandy.jpg", true, "Fruit Gummy Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 2, "~\\Images\\FruitCandy2.jpg", false, "Assorted Cherry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 2, "~\\Images\\FruitCandy3.jpg", false, "Assorted Gummy Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, "~\\Images\\chocolateCandy.jpg", false, "Assorted Chocolate Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "~\\Images\\chocolateCandy2.jpg", "Assorted Berry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { "~\\Images\\chocolateCandy3.jpg", false, "Delicious Ghost Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { 4, "~\\Images\\fruitCandy.jpg", true, "Fruit Cherry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, "~\\Images\\fruitCandy2.jpg", true, true, "Assorted Berry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name" },
                values: new object[] { 2, "~\\Images\\fruitCandy3.jpg", false, "Assorted Berry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "ImageUrl", "IsInStock", "Name", "Price" },
                values: new object[] { "~\\Images\\gummyCandy.jpg", true, "Delicious Berry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, "~\\Images\\gummyCandy2.jpg", true, false, "Fun Ghost Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "Name" },
                values: new object[] { 4, "~\\Images\\gummyCandy3.jpg", false, "Fruit Berry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "~\\Images\\hardCandy.jpg", "Fruit Strawberry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "CategoryId", "ImageUrl", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, "~\\Images\\hardCandy2.jpg", false, "Assorted Strawberry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "CategoryId", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, "~\\Images\\hardCandy3.jpg", false, true, "Assorted Ghost Candy", 5.95m });
        }
    }
}
