using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseFantastic.DataAccess.Models
{
    public class CourseFantasticDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=CourseFantasticDb;User ID=sa;Password=tafe;");
        }
    }
}
