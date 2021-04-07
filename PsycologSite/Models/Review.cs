using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace PsycologSite.Models
{
    public class Review
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Commentary { get; set; }
    }
    public class ApplicationContext:DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options):
            base(options)
        {
            Database.EnsureCreated();
        }
    }
}
