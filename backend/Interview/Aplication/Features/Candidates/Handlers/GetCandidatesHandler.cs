using Aplication.Abstractions;
using Aplication.Abstractions.Handlers;
using Aplication.Features.Candidates.Models;
using Aplication.Features.Candidates.Queries;
using Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Features.Candidates.Handlers
{
    public class GetVotersHandler : BaseApiHandler<GetCandidatesQuery, IEnumerable<CandidateDto>>
    {
        public GetVotersHandler(IAppDbContext dataContext) : base(dataContext)
        {

        }

        public override async Task<ApiResponse<IEnumerable<CandidateDto>>> Handle(GetCandidatesQuery request, CancellationToken cancellationToken)
        {
            var candidates = await DataContext.Candidates
                .Include(c => c.Voters)
                .Select(c => new CandidateDto(c.Id, c.Name ?? "", c.Voters != null ? c.Voters.Count : 0))
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return Response(candidates);
        }
    }
}
