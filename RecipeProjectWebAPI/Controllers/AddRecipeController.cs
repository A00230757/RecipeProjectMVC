using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeProjectMVC.Data;
using RecipeProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProjectWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddRecipeController : ControllerBase
    {
        private readonly RecipeContext _context;

        public AddRecipeController(RecipeContext context)
        {
            _context = context;
        }

        // GET: Recipes

        [HttpPost]
        public void AddRecipe([FromQuery] String name, [FromQuery] String foodcat, [FromQuery] String title, [FromQuery] String description, [FromQuery] String preptime, String cooktime, [FromQuery] String ingredients, [FromQuery] String tools, [FromQuery] String cookingsteps, [FromQuery] String photo1, [FromQuery] String photo2, [FromQuery] String photo3, [FromQuery] String ranking)

        {
            //if (ModelState.IsValid)
            //{
                _context.Add(new Recipe { Name = name, FoodCategory = foodcat, Title = title, Description = description, PrepTime = preptime, CookTime = cooktime, Ingredients = ingredients, Tools = tools, CookingSteps = cookingsteps, Photo1 = photo1, Photo2 = photo2, Photo3 = photo3, Ranking = ranking });
                _context.SaveChangesAsync();
                RedirectToAction(nameof(Index));
           // }
            //return CalculatorTasks.AdditionTask(number1, number2);
        }
      
    }
}
