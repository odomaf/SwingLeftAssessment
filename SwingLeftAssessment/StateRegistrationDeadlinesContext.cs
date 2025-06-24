using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SwingLeftAssessment;

public partial class StateRegistrationDeadlinesContext : DbContext
{
    public StateRegistrationDeadlinesContext()
    {
    }

    public StateRegistrationDeadlinesContext(DbContextOptions<StateRegistrationDeadlinesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VoterRegistrationDeadline> VoterRegistrationDeadlines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=state_registration_deadlines;Username=postgres;Password=assessment");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VoterRegistrationDeadline>(entity =>
        {
            entity.HasKey(e => e.State).HasName("firstkey");

            entity.ToTable("voter_registration_deadlines");

            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Deadlineinperson)
                .HasMaxLength(50)
                .HasColumnName("deadlineinperson");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
