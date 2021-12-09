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
       
                _context.Add(new Recipe {RecipeId =4, Name = name, FoodCategory = foodcat, Title = title, Description = description, PrepTime = preptime, CookTime = cooktime, Ingredients = ingredients, Tools = tools, CookingSteps = cookingsteps, Photo1 = photo1, Photo2 = photo2, Photo3 = photo3, Ranking = ranking });
                _context.SaveChangesAsync();
               
        
        }
        [HttpGet]
        public string ViewRecipeList()
        {
            Task<List<Recipe>> task = _context.Recipe.ToListAsync();

            int count = task.Result.Count;
            string s = "";
            for ( int i = 0; i < count; i++)
            {
                s = s + "RecipeId:- " + task.Result[i].RecipeId + "@";
                s = s + "Name:- " + task.Result[i].Name + "@";
                s = s + "FoodCategory:- " + task.Result[i].FoodCategory + "@";
                s = s + "Title:- " + task.Result[i].Title + "@";
                s = s + "Description:- " + task.Result[i].Description + "@";
                s = s + "PrepTime:- " + task.Result[i].PrepTime + "@";
                s = s + "CookTime:- " + task.Result[i].CookTime+ "@";
                s = s + "Ingredients:- " + task.Result[i].Ingredients + "@";
                s = s + "Tools:- " + task.Result[i].Tools+ "@";
                s = s + "CookingSteps:- " + task.Result[i].CookingSteps + "@";
                s = s + "Photo1:- " + task.Result[i].Photo1 + "@";
                s = s + "Photo2:- " + task.Result[i].Photo2 + "@";
                s = s + "Photo3:- " + task.Result[i].Photo3 + "@";
                s = s + "Ranking:- " + task.Result[i].Ranking+ "@";
                s = s + "@";
                s = s + "----------------------------------------------@";
                s = s.Replace("@", " " + System.Environment.NewLine);
            }
               
             



            return s;
        }

    }
}
