using Microsoft.EntityFrameworkCore;
using TableReservationSystem.Models;

namespace TableReservationSystem.Data
{
    public class TableReservationSystemContext : DbContext
    {
        public TableReservationSystemContext (DbContextOptions<TableReservationSystemContext> options)
            : base(options)
        {
        }

        public DbSet<TableReservationSystem.Models.Table> Table { get; set; }

        public DbSet<TableReservationSystem.Models.Reservation> Reservation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
