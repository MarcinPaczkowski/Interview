using Aplication.Abstractions;
using Aplication.Abstractions.Handlers;
using Aplication.Features.Voters.Models;
using Aplication.Features.Voters.Queries;
using Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Features.Voters.Handlers
{
    public class GetVotersHandler : BaseApiHandler<GetVotersQuery, IEnumerable<VoterDto>>
    {
        public GetVotersHandler(IAppDbContext dataContext) : base(dataContext)
        {

        }

        public override async Task<ApiResponse<IEnumerable<VoterDto>>> Handle(GetVotersQuery request, CancellationToken cancellationToken)
        {
            var voters = await DataContext.Voters
                .Include(v => v.Candidate)
                .Select(v => new VoterDto(v.Id, v.Name ?? "", v.Candidate != null))
                .AsNoTracking()
                .ToListAsync(cancellationToken);
            return Response(voters);
        }
    }
}
