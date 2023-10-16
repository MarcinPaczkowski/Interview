using Aplication.Interfaces;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Voter> Voters { get; set; }

        public async Task<int> SaveChanges(CancellationToken cancellationToken = default) => await base.SaveChangesAsync(cancellationToken);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voter>()
                .HasOne(c => c.Candidate)
                .WithMany(v => v.Voters)
                .HasForeignKey(c => c.CandidateId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
