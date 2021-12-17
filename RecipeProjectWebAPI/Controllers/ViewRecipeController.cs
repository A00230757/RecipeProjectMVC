using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeProjectMVC.Data;
using RecipeProjectMVC.Models;
using RecipeProjectClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RecipeProjectWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ViewRecipeController : ControllerBase
    {
        private readonly RecipeContext _context;

        public ViewRecipeController(RecipeContext context)
        {
            _context = context;
        }

        // GET: Recipes

        [HttpGet]
        public string ViewRecipeList()
        {
            Task<List<Recipe>> task = _context.Recipe.ToListAsync();
            //Task<List<Recipe>> task = AddRecipeTasks.ViewRecipeList();
           

            int count = task.Result.Count;
            string s = "";
            for (int i = 0; i < count; i++)
            {
                s = s + "RecipeId:- " + task.Result[i].RecipeId + "@";
                s = s + "Name:- " + task.Result[i].Name + "@";
                s = s + "FoodCategory:- " + task.Result[i].FoodCategory + "@";
                s = s + "Title:- " + task.Result[i].Title + "@";
                s = s + "Description:- " + task.Result[i].Description + "@";
                s = s + "PrepTime:- " + task.Result[i].PrepTime + "@";
                s = s + "CookTime:- " + task.Result[i].CookTime + "@";
                s = s + "Ingredients:- " + task.Result[i].Ingredients + "@";
                s = s + "Tools:- " + task.Result[i].Tools + "@";
                s = s + "CookingSteps:- " + task.Result[i].CookingSteps + "@";
                s = s + "Photo1:- " + task.Result[i].Photo1 + "@";
                s = s + "Photo2:- " + task.Result[i].Photo2 + "@";
                s = s + "Photo3:- " + task.Result[i].Photo3 + "@";
                s = s + "Ranking:- " + task.Result[i].Ranking + "@";
                s = s + "@";
                s = s + "----------------------------------------------@";
                s = s.Replace("@", " " + System.Environment.NewLine);
            }
            s = s + "----------------length------------------------------@"+count;

            string json = JsonConvert.SerializeObject(task.Result);


            return json;
        }

    }
}
