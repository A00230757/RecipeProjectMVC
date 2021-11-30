using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProjectMVC.Models
{
    public class UserComments
    {

        [Key]
        public int CommentId { get; set; }

       
        public string commentTitle { get; set; }

       
        public string CommentDetail { get; set; }

        public ICollection<Recipe> RecipeId { get; set; }

        public ICollection<User> UserName { get; set; }
    }
}
