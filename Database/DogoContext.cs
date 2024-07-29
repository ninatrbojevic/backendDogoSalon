using Microsoft.EntityFrameworkCore;
using dogo_api.Database.Entities;

namespace dogo_api.Database
{
    public class DogoContext : DbContext
    {
        public DogoContext(DbContextOptions<DogoContext> options)
            : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
