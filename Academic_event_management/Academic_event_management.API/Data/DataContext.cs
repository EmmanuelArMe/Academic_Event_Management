using Academic_event_management.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academic_event_management.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<AcademicEvent> AcademicEvents { get; set; }
        public DbSet<Attendee> Attendees { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
