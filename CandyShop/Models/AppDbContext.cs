using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chocolate Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Gummy Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Halloween Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Hard Candy" });



            int candyIdCounter = 2;
            Random rng = new Random();

            string[] randomFirstName = {"Assorted", "Delicious", "Fun", "Pink", "Fruit", "Hard" };
            string[] randomSecondName = {"Chocolate", "Strawberry", "Cherry", "Berry", "Gummy", "Ghost", "Bear" };

            decimal[] prices = { 2.50M, 2.95M, 3.50M, 3.95M, 4.95M, 5.95M };

            string loremIpsum = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,
            molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum
            numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium
            optio, eaque rerum!Provident similique accusantium nemo autem.";

            string[,] imgArray = { 
                { "\\Images\\FruitCandy.jpg", "\\Images\\thumbnails\\fruitCandy-small.jpg" },
                { "\\Images\\FruitCandy2.jpg", "\\Images\\thumbnails\\fruitCandy2-small.jpg" },
                { "\\Images\\FruitCandy3.jpg", "\\Images\\thumbnails\\fruitCandy3-small.jpg" },
                { "\\Images\\chocolateCandy.jpg", "\\Images\\thumbnails\\chocolateCandy-small.jpg" },
                { "\\Images\\chocolateCandy2.jpg", "\\Images\\thumbnails\\chocolateCandy2-small.jpg" },
                { "\\Images\\chocolateCandy3.jpg", "\\Images\\thumbnails\\chocolateCandy3-small.jpg" },
                { "\\Images\\fruitCandy.jpg", "\\Images\\thumbnails\\fruitCandy-small.jpg" },
                { "\\Images\\fruitCandy2.jpg", "\\Images\\thumbnails\\fruitCandy2-small.jpg" },
                { "\\Images\\fruitCandy3.jpg", "\\Images\\thumbnails\\fruitCandy3-small.jpg" },
                { "\\Images\\gummyCandy.jpg", "\\Images\\thumbnails\\gummyCandy-small.jpg" },
                { "\\Images\\gummyCandy2.jpg", "\\Images\\thumbnails\\gummyCandy2-small.jpg" },
                { "\\Images\\gummyCandy3.jpg", "\\Images\\thumbnails\\gummyCandy3-small.jpg" },
                { "\\Images\\hardCandy.jpg", "\\Images\\thumbnails\\hardCandy-small.jpg" },
                { "\\Images\\hardCandy2.jpg", "\\Images\\thumbnails\\hardCandy2-small.jpg" },
                { "\\Images\\hardCandy3.jpg", "\\Images\\thumbnails\\hardCandy3-small.jpg" }
            }; 

            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                CandyId = 1,
                Name = "Assorted Chocolate Candy",
                Price = 4.95M,
                Description = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,
                molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum
                numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium
                optio, eaque rerum! Provident similique accusantium nemo autem.",
                CategoryId = 1,
                ImageUrl = "\\images\\chocolateCandy.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            }
            );
            for(int i = 0; i < imgArray.GetLength(0); i++)
            {
                modelBuilder.Entity<Candy>().HasData(new Candy
                {
                    CandyId = candyIdCounter++,
                    Name = $"{randomFirstName[rng.Next(0, randomFirstName.Length - 1)]} {randomSecondName[rng.Next(0, randomSecondName.Length - 1)]} Candy",
                    Price = prices[rng.Next(0, prices.Length)],
                    Description = loremIpsum,
                    CategoryId = rng.Next(1, 5),
                    ImageUrl = imgArray[i,0],
                    ImageThumbnailUrl = imgArray[i, 1],
                    IsInStock = rng.Next(0,10) > 4 ? true : false,
                    IsOnSale = rng.Next(0, 10) > 2 ? true : false
                }); ; 
            }
            
        }
    }
}
