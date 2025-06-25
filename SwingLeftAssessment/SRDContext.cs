using SwingLeftAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace SwingLeftAssessment
{
    public class SRDContext : DbContext
    {
        public SRDContext(DbContextOptions<SRDContext> options) : base(options)
        {
        }

        public DbSet<voter_registration_deadlines> voter_registration_deadlines { get; set; }
    }
}
