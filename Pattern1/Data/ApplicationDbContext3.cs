using Microsoft.EntityFrameworkCore;
using Pattern1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pattern1.Data
{
    public class ApplicationDbContext3 : DbContext
    {
        public ApplicationDbContext3(DbContextOptions<ApplicationDbContext3> options)
           : base(options)
        {
        }

        public DbSet<LookUp> LookUps { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
