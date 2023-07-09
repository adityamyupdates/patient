using Microsoft.EntityFrameworkCore;


    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<PatientDetails> PatientDetails => Set<PatientDetails>();
        public DbSet<Organization> Organization => Set<Organization>();
        public DbSet<VisitDetails> VisitDetails => Set<VisitDetails>();
    }

