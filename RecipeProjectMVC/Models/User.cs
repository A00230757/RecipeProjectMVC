using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProjectMVC.Models
{
    public class User
    {

        [Key]
        public string Username { get; set; }

        
        public string Email { get; set; }

      
        public int Age { get; set; }

       
        public string Nationality { get; set; }

    }
}
