using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class SeedingDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\fruitCandy-small.jpg", "~\\Images\\FruitCandy.jpg", true, true, "Fruit Gummy Candy", 4.95m },
                    { 3, 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\fruitCandy2-small.jpg", "~\\Images\\FruitCandy2.jpg", false, true, "Assorted Cherry Candy", 2.95m },
                    { 4, 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\fruitCandy3-small.jpg", "~\\Images\\FruitCandy3.jpg", false, true, "Assorted Gummy Candy", 4.95m },
                    { 5, 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\chocolateCandy-small.jpg", "~\\Images\\chocolateCandy.jpg", true, false, "Assorted Chocolate Candy", 3.50m },
                    { 6, 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\chocolateCandy2-small.jpg", "~\\Images\\chocolateCandy2.jpg", true, true, "Assorted Berry Candy", 5.95m },
                    { 7, 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\chocolateCandy3-small.jpg", "~\\Images\\chocolateCandy3.jpg", false, true, "Delicious Ghost Candy", 2.50m },
                    { 8, 4, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\fruitCandy-small.jpg", "~\\Images\\fruitCandy.jpg", true, true, "Fruit Cherry Candy", 3.95m },
                    { 9, 4, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\fruitCandy2-small.jpg", "~\\Images\\fruitCandy2.jpg", true, true, "Assorted Berry Candy", 2.95m },
                    { 10, 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\fruitCandy3-small.jpg", "~\\Images\\fruitCandy3.jpg", false, true, "Assorted Berry Candy", 3.95m },
                    { 11, 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\gummyCandy-small.jpg", "~\\Images\\gummyCandy.jpg", true, false, "Delicious Berry Candy", 2.95m },
                    { 12, 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\gummyCandy2-small.jpg", "~\\Images\\gummyCandy2.jpg", true, false, "Fun Ghost Candy", 4.95m },
                    { 13, 4, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\gummyCandy3-small.jpg", "~\\Images\\gummyCandy3.jpg", false, true, "Fruit Berry Candy", 3.50m },
                    { 14, 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\hardCandy-small.jpg", "~\\Images\\hardCandy.jpg", false, true, "Fruit Strawberry Candy", 2.95m },
                    { 15, 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\hardCandy2-small.jpg", "~\\Images\\hardCandy2.jpg", false, false, "Assorted Strawberry Candy", 3.95m },
                    { 16, 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.", "\\Images\\thumbnails\\hardCandy3-small.jpg", "~\\Images\\hardCandy3.jpg", false, true, "Assorted Ghost Candy", 5.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16);
        }
    }
}
