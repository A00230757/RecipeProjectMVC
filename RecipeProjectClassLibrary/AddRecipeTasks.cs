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
using Microsoft.EntityFrameworkCore;

namespace RecipeProjectClassLibrary
{
   public  class AddRecipeTasks
    {
        public static RecipeContext _context;

        public AddRecipeTasks(RecipeContext context)
        {
            _context = context;
        }
        public static Task<List<Recipe>> ViewRecipeList()
        {
            Task<List<Recipe>> task = _context.Recipe.ToListAsync();

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





            return task;
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
