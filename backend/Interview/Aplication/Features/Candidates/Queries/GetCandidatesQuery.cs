using Aplication.Abstractions;
using Aplication.Features.Candidates.Models;

namespace Aplication.Features.Candidates.Queries
{
    public record GetCandidatesQuery : BaseApiRequest<IEnumerable<CandidateDto>>;
}
