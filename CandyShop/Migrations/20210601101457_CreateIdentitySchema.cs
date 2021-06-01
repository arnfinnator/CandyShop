using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShop.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 2, true, "Pink Strawberry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 3, false, "Assorted Ghost Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { false, true, "Pink Ghost Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, true, true, "Assorted Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 1, true, "Pink Ghost Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 3, "Pink Strawberry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Assorted Berry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 1, "Pink Chocolate Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, false, "Pink Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, true, "Assorted Berry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 2, true, "Pink Strawberry Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 2, false, "Assorted Chocolate Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 1, "Fruit Strawberry Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "CategoryId", "IsOnSale", "Name" },
                values: new object[] { 1, false, "Assorted Cherry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, false, "Assorted Ghost Candy", 4.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 3, false, "Fun Strawberry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, true, "Assorted Chocolate Candy", 5.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 4,
                columns: new[] { "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { true, false, "Pink Strawberry Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5,
                columns: new[] { "CategoryId", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 4, false, false, "Fun Chocolate Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, false, "Assorted Ghost Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 1, "Fun Cherry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 1, "Delicious Gummy Candy", 3.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 4, "Fun Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, true, "Fun Chocolate Candy", 4.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 2, false, "Assorted Gummy Candy", 2.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, false, "Assorted Cherry Candy", 2.50m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13,
                columns: new[] { "CategoryId", "IsInStock", "Name", "Price" },
                values: new object[] { 4, true, "Fruit Gummy Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 14,
                columns: new[] { "CategoryId", "Name", "Price" },
                values: new object[] { 2, "Pink Cherry Candy", 3.95m });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 15,
                columns: new[] { "CategoryId", "IsOnSale", "Name" },
                values: new object[] { 2, true, "Fruit Strawberry Candy" });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 16,
                columns: new[] { "CategoryId", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, true, "Assorted Strawberry Candy", 5.95m });
        }
    }
}
