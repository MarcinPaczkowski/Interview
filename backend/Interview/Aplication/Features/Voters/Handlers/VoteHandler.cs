using Aplication.Abstractions.Handlers;
using Aplication.Abstractions;
using Aplication.Interfaces;
using Aplication.Features.Voters.Commands;
using Microsoft.EntityFrameworkCore;
using Domain.Exceptions;

namespace Aplication.Features.Voters.Handlers
{
    public class VoteHandler : BaseApiHandler<VoteCommand, bool>
    {
        public VoteHandler(IAppDbContext dataContext) : base(dataContext)
        {

        }

        public override async Task<ApiResponse<bool>> Handle(VoteCommand request, CancellationToken cancellationToken)
        {
            var voter = await DataContext.Voters.FirstOrDefaultAsync(v => v.Id == request.VoteRequest.VoterId, cancellationToken) ?? throw new VoterNotFoundException(request.VoteRequest.VoterId);
            if (voter.HasVoted()) 
                throw new VoterHasAlreadyVotedException(request.VoteRequest.VoterId);
            var candidate = await DataContext.Candidates.FirstOrDefaultAsync(c => c.Id == request.VoteRequest.CandidateId, cancellationToken) ?? throw new CandidateNotFoundException(request.VoteRequest.CandidateId);
            voter.Vote(request.VoteRequest.CandidateId);
            await DataContext.SaveChanges(cancellationToken);
            return Response(true);
        }
    }
}
