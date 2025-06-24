using Microsoft.EntityFrameworkCore;

namespace SwingLeftAssessment.Entities
{

    // EFCoreDbContext class inherits from DbContext, which is the primary class for interacting with the database using EF Core.
    public class EFCoreDbContext : DbContext
    {

        // Constructor that accepts DbContextOptions<EFCoreDbContext> as a parameter.
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database provider and connection string.
            optionsBuilder.UseNpgsql("Host=localhost;Database=state_registration_deadlines;Username=postgres;Password=assessment");
        }

        //represents a table in the database corresponding to the VoterRegistrationDeadlines entity.
        public DbSet<VoterRegistrationDeadlines> VoterRegistrationDeadlines { get; set; }
    }

        
}
