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
    public class SearchRecipeController : ControllerBase
    {
        private readonly RecipeContext _context;

        public SearchRecipeController(RecipeContext context)
        {
            _context = context;
        }

        // GET: Recipes

        [HttpGet]
        public string SearchRecipeList([FromQuery] String recipeid)
        {
            Task<List<Recipe>> task = _context.Recipe.ToListAsync();
            //Task<List<Recipe>> task = AddRecipeTasks.ViewRecipeList();
          

            int count = task.Result.Count;
            string s = "No Data Found For This RecipeId";

            for (int i = 0; i < count; i++)
            {
                string rid = task.Result[i].RecipeId.ToString();
                Console.WriteLine(recipeid+"--" + task.Result[i].RecipeId);
                if (recipeid.Equals(rid))
                {
                    string json = JsonConvert.SerializeObject(task.Result[i]);
                    s = json;
                    break;
                }
            }


            return s;


        }

    }
}
