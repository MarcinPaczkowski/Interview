using Aplication.Abstractions;
using Aplication.Features.Voters.Models;

namespace Aplication.Features.Voters.Commands
{
    public record CreateVoterCommand(CreateVoterRequest CreateVoterRequest) : BaseApiRequest<VoterDto>;    
}
