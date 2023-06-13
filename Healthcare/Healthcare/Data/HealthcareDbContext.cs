using Healthcare.Models;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Data
{
    public class HealthcareDbContext : DbContext
    {
        public HealthcareDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
    }   
}
