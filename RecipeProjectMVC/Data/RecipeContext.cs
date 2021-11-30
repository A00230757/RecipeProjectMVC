using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace RecipeProjectMVC.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserComments> UserComments { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}
