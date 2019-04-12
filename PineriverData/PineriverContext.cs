using PineriverData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace PineriverData
{
    public class PineriverContext : DbContext
    {

        public DbSet<Post> posts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=gs12.sv-hosting.com;Database=Pineriver;user id = amdaoff; password = @210100KBK;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(pk => pk.Post_ID);
        }

    }
}
