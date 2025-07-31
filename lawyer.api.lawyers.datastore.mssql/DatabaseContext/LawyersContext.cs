using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Model.Common;
using Microsoft.EntityFrameworkCore;

namespace lawyer.api.lawyers.datastore.mssql.DatabaseContext;

public class LawyersContext : DbContext
{
    public LawyersContext(DbContextOptions<LawyersContext> options) : base(options)
    {
    }

    public DbSet<LawyerEntity> Lawyers { get; set; }
    public DbSet<AcademicInfoEntity> AcademicInfos { get; set; }
    public DbSet<ExampleEntity> Examples { get; set; }
    public DbSet<LawFirmEntity> LawFirms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LawyersContext).Assembly);

        modelBuilder.Entity<LawyerEntity>()
            .HasOne(l => l.LawFirm)
            .WithMany(f => f.Lawyers)
            .HasForeignKey(l => l.LawFirmId);

        modelBuilder.Entity<LawyerEntity>()
            .HasMany(l => l.AcademicInfos)
            .WithOne(ai => ai.Lawyer)
            .HasForeignKey(ai => ai.LawyerId);
        
        modelBuilder.Entity<LawFirmEntity>()
            .HasMany(f => f.Lawyers)
            .WithOne(l => l.LawFirm)
            .HasForeignKey(l => l.LawFirmId);

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<EFEntity>()
                     .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.DateModified = DateTime.Now;
            if (entry.State == EntityState.Added) entry.Entity.DateCreated = DateTime.Now;
        }

        return base.SaveChangesAsync(cancellationToken);
    }}