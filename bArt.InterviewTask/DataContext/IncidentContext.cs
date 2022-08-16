using bArt.InterviewTask.DataModels;
using Microsoft.EntityFrameworkCore;

namespace bArt.InterviewTask.DataContext
{
    public class IncidentContext : DbContext
    {
        //public static readonly string ConnectionString = "DefaultConnection";
        public IncidentContext()
        { }

        public IncidentContext(DbContextOptions<IncidentContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
