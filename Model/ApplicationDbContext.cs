using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

        //Here I'm seeding some data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Author = "Kinawy",
                    Name = "C# 10"
                },
                new Book
                {
                    Id = 2,
                    Author = "Kino",
                    Name = "Asp.net Core"
                });

        }
    }
}
