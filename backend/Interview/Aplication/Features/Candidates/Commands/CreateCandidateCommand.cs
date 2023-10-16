using Aplication.Abstractions;
using Aplication.Features.Candidates.Models;

namespace Aplication.Features.Candidates.Commands
{
    public record CreateCandidateCommand(CreateCandidateRequest CreateCandidateRequest) : BaseApiRequest<CandidateDto>;
}
