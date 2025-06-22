using Microsoft.EntityFrameworkCore;

namespace FaultTracker.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Fault> Faults { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fault>().HasData(
                new Fault
                {
                    Id = 1,
                    Title = "Power outage",
                    Description = "Sudden power failure in district 3",
                    ReportedAt = new DateTime(2025, 6, 22, 16, 0, 0, DateTimeKind.Utc),
                    Status = "Open"
                },
                new Fault
                {
                    Id = 2,
                    Title = "System overload",
                    Description = "Load exceeded threshold during peak hours",
                    ReportedAt = new DateTime(2025, 6, 22, 19, 0, 0, DateTimeKind.Utc),
                    Status = "Investigating"
                }
            );
        }

    }

}