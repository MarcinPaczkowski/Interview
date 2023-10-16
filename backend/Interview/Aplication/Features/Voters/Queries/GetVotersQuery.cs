using Aplication.Abstractions;
using Aplication.Features.Voters.Models;

namespace Aplication.Features.Voters.Queries
{
    public record GetVotersQuery : BaseApiRequest<IEnumerable<VoterDto>>;
}
