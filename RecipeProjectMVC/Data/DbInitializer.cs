using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeProjectMVC.Models;

namespace RecipeProjectMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecipeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Recipe.Any())
            {
                return;   // DB has been seede
            }

            var recipe = new Recipe[]
            {
            new Recipe{RecipeId=1,Name="chicken",FoodCategory="Non veg",Title="ch",Description="ds" ,
                PrepTime ="01",CookTime="01",
            Ingredients="ds",Tools="ds",CookingSteps="ds",Photo1="ds",Photo2="ds",
            Photo3="ds",Ranking="ds"},
             new Recipe{RecipeId=2,Name="fish",FoodCategory="Non veg",Title="ch",Description="ds" ,
                PrepTime ="01",CookTime="01",
            Ingredients="ds",Tools="ds",CookingSteps="ds",Photo1="ds",Photo2="ds",
            Photo3="ds",Ranking="ds"},
            };
            foreach (Recipe r in recipe)
            {
                context.Recipe.Add(r);
            }
            context.SaveChanges();


            var users = new User[]
          {
            new User{Username="abc",Email="abc@gmail.com",Age=30, Nationality="Canadian"},
             new User{Username="def",Email="def@gmail.com",Age=32, Nationality="Canadian"},
          };
            foreach (User u in users)
            {
                context.User.Add(u);
            }
            context.SaveChanges();



       /*     var usercomments = new UserComments[]
          {
            new UserComments{CommentId=1,commentTitle="ct1",CommentDetail="cd1", RecipeId=1,UserName="abc"},
          };
            foreach (UserComments uc in usercomments)
            {
                context.UserComments.Add(uc);
            }
            context.SaveChanges();*/


        }
    }
}
