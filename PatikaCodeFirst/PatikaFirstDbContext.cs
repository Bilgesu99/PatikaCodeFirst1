using Microsoft.EntityFrameworkCore;
using PatikaCodeFirst.Models;

namespace PatikaCodeFirst
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
        }
    }
}
