using FirstEntityCore.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstEntityCore.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"Host=localhost;User Id=postgres;Password=postgres;Database=univer;";
            optionsBuilder.UseNpgsql(path);
        }
    }
}
