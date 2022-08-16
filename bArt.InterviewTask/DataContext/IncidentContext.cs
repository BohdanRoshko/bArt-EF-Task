using bArt.InterviewTask.DataModels;
using Microsoft.EntityFrameworkCore;

namespace bArt.InterviewTask.DataContext
{
    public class IncidentContext : DbContext
    {
        public IncidentContext()
        { }

        public IncidentContext(DbContextOptions<IncidentContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
