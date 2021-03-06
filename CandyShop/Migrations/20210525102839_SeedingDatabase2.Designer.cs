// <auto-generated />
using CandyShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210525102839_SeedingDatabase2")]
    partial class SeedingDatabase2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n                molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n                numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n                optio, eaque rerum! Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "~\\images\\thumbnails\\chocolateCandy-small.jpg",
                            ImageUrl = "~\\images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                            ImageUrl = "~\\Images\\FruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Gummy Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                            ImageUrl = "~\\Images\\FruitCandy2.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Cherry Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 4,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                            ImageUrl = "~\\Images\\FruitCandy3.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                            ImageUrl = "~\\Images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 3.50m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                            ImageUrl = "~\\Images\\chocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Berry Candy",
                            Price = 5.95m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                            ImageUrl = "~\\Images\\chocolateCandy3.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Delicious Ghost Candy",
                            Price = 2.50m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                            ImageUrl = "~\\Images\\fruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Cherry Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                            ImageUrl = "~\\Images\\fruitCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Berry Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                            ImageUrl = "~\\Images\\fruitCandy3.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Berry Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                            ImageUrl = "~\\Images\\gummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Delicious Berry Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                            ImageUrl = "~\\Images\\gummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Fun Ghost Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 13,
                            CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                            ImageUrl = "~\\Images\\gummyCandy3.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Fruit Berry Candy",
                            Price = 3.50m
                        },
                        new
                        {
                            CandyId = 14,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy-small.jpg",
                            ImageUrl = "~\\Images\\hardCandy.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Fruit Strawberry Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 15,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                            ImageUrl = "~\\Images\\hardCandy2.jpg",
                            IsInStock = false,
                            IsOnSale = false,
                            Name = "Assorted Strawberry Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 16,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,\r\n            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum\r\n            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium\r\n            optio, eaque rerum!Provident similique accusantium nemo autem.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                            ImageUrl = "~\\Images\\hardCandy3.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "Assorted Ghost Candy",
                            Price = 5.95m
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Candy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Candy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Candy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Candy"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Navigation("Candies");
                });
#pragma warning restore 612, 618
        }
    }
}
