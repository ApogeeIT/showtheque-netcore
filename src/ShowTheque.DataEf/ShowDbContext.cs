using Microsoft.EntityFrameworkCore;
using ShowTheque.Business.Models;

namespace ShowTheque.DataEf
{
    public class ShowDbContext : DbContext
    {
        public ShowDbContext(DbContextOptions options)
                : base(options)
        {
        }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Season> Seasons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>()
                .ToTable("Show");
        }
    }


}