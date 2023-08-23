using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaginatingEFCore.Models;

namespace PaginatingEFCore.Data
{
    public class AppDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KDHQCIN;Initial Catalog=Tours;Trusted_Connection=True;TrustServerCertificate=True;User Id=sa;Password=@Stockholm01");
            //.LogTo(Console.WriteLine, LogLevel.Information);
        }
        public DbSet<TourDTO> Tours_table { get; set; }

    }
}
