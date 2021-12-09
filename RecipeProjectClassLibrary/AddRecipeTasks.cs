using RecipeProjectMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeProjectMVC.Controllers;
using RecipeProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace RecipeProjectClassLibrary
{
    class AddRecipeTasks
    {
        private readonly RecipeContext _context;

        public AddRecipeTasks(RecipeContext context)
        {
            _context = context;
        }
        
     /*   public static double AdditionTask(double number1, double number2)//this task of class library accept
                                                                         //two numbers of double data type and return their sum
        {
            Recipe rs = new Recipe();
            return number1 + number2;
        }*/

     /*          public static double AdditionTask(String Name, String FoodCategory, String Title, String Description,DateTime PrepTime, DateTime CookTime, String Ingredients, String Tools, String CookingSteps, String Photo1, String Photo2, String Photo3,String Ranking)
                                                                  
        {
            Recipe rs = new Recipe();
            return number1 + number2;
            _context.Add(recipe);
            await _context.SaveChangesAsync();
            return 2.0;
        }*/
    }
}
