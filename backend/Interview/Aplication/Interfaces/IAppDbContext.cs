using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Candidate> Candidates { get; set; }
        DbSet<Voter> Voters { get; set; }
        Task<int> SaveChanges(CancellationToken cancellationToken = default);
    }
}
