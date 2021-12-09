using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProjectMVC.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string FoodCategory { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrepTime { get; set; }
        public string CookTime { get; set; }
        public string Ingredients { get; set; }
        public string Tools { get; set; }
        public string CookingSteps { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }

        public string Photo3 { get; set; }
        public string Ranking { get; set; }


       
    }
}
