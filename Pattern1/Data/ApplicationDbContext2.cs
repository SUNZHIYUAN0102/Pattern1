using Microsoft.EntityFrameworkCore;
using Pattern1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pattern1.Data
{
    public class ApplicationDbContext2 : DbContext
    {
        public ApplicationDbContext2(DbContextOptions<ApplicationDbContext2> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }

}
