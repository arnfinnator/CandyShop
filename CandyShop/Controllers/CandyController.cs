using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        // The _namingConvension is common for private fields
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        // the Constructor method instantiates the controller
        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Candy> candies;
            string currentCategory;

            // null or empty string:
            if (string.IsNullOrEmpty(category))
            {
                //fills the ienumerable of candy 'candies' with the result of getallcandy,
                //from the repository, ordered by candy id
                candies = _candyRepository.GetAllCandy.OrderBy(c => c.CandyId);
                //Since all candies are selected, category set to All Candy
                currentCategory = "All Candy";
            }
            //otherwise, if string supplied is not null or empty. 
            else
            {
                //Look for match of supplied string (category) in repository
                candies = _candyRepository.GetAllCandy.Where(c => c.Category.CategoryName == category);
                //Sets currentCategory to the first element from the getallcategories method where categoryName and category matches,
                //but also something something
                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CandyListViewModel
            {
                Candies = candies,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if(candy == null)
            {
                return NotFound();
            }
            return View(candy);
        }

    }
}
