using Aplication.Abstractions;
using Aplication.Features.Voters.Models;

namespace Aplication.Features.Voters.Commands
{
    public record VoteCommand(VoteRequest VoteRequest) : BaseApiRequest<bool>;
}
