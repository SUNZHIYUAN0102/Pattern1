using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pattern1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pattern1.Data
{
    public class ApplicationDbContext1 : DbContext
    {
        public ApplicationDbContext1(DbContextOptions<ApplicationDbContext1> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
