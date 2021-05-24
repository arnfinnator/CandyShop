using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {

        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();


        public IEnumerable<Candy> GetAllCandy => new List<Candy> 
        {
            new Candy
            {
                CandyId = 1,
                Name = "Assorted Hard Candy",
                Price = 4.95M,
                Description = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,
                molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum
                numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium
                optio, eaque rerum! Provident similique accusantium nemo autem.",
                Category = _categoryRepository.GetAllCategories.ToList()[0],
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/1280px-HardCandy.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/220px-HardCandy.jpg"
            },
            new Candy
            {
                CandyId = 2,
                Name = "Assorted Chocolate Candy",
                Price = 5.95M,
                Description = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,
                molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum
                numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium
                optio, eaque rerum! Provident similique accusantium nemo autem.",
                Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/70/Chocolate_%28blue_background%29.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Chocolate_%28blue_background%29.jpg/200px-Chocolate_%28blue_background%29.jpg"
            },
                new Candy
            {
                CandyId = 3,
                Name = "Assorted Fruit  Candy",
                Price = 5.95M,
                Description = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia,
                molestiae quas vel sint commodi repudiandae consequuntur voluptatum laborum
                numquam blanditiis harum quisquam eius sed odit fugiat iusto fuga praesentium
                optio, eaque rerum! Provident similique accusantium nemo autem.",
                Category = _categoryRepository.GetAllCategories.ToList()[2],
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Welch%27s_Fruit_Snacks_%284239096810%29.jpg/1280px-Welch%27s_Fruit_Snacks_%284239096810%29.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Welch%27s_Fruit_Snacks_%284239096810%29.jpg/220px-Welch%27s_Fruit_Snacks_%284239096810%29.jpg"
            }
        };

        public IEnumerable<Candy> GetCanyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
