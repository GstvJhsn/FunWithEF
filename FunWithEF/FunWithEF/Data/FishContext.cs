using Microsoft.EntityFrameworkCore;
using FunWithEF.Model;


namespace FunWithEF.Data
{
    public class FishContext : DbContext
    {
        public DbSet<Fish> Shoal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

    }
}