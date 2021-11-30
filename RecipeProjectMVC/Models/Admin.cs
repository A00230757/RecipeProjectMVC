﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProjectMVC.Models
{
    public class Admin
    {

        [Key]
        public string Email { get; set; }
        public string Name { get; set; }
        
        public string MobileNumber { get; set; }
    }
}
