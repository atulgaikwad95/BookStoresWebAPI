using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Models
{
    public class BookStoresDbContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=BookStoresDB;Integrated Security=True");
        }
    }
}
