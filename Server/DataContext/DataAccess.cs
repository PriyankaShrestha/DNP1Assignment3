using Microsoft.EntityFrameworkCore;
using Models;

namespace Server.DataContext
{
    public class DataAccess : DbContext
    {
        public DbSet<Family> FamiliesDB { get; set; }

        public DbSet<User> UsersDB { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = FamilyRegister.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Family>().HasKey(f =>
                new {f.City, f.StreetName, f.HouseNumber, f.Floor});
        }
    }
}