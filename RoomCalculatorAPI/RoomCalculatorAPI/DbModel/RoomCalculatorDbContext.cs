using Microsoft.EntityFrameworkCore;
using RoomCalculatorAPI.Models;

namespace RoomCalculatorAPI.DbModel
{
    public class RoomCalculatorDbContext : DbContext
    {
        public RoomCalculatorDbContext(DbContextOptions<RoomCalculatorDbContext> options) : base(options){}

        public DbSet<RoomHistory> RoomHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RoomHistory>().ToTable("RoomHistory");
        }
    }
}
