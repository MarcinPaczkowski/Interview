using Aplication.Abstractions;
using Aplication.Abstractions.Handlers;
using Aplication.Features.Voters.Commands;
using Aplication.Features.Voters.Models;
using Aplication.Interfaces;
using Domain.Entites;

namespace Aplication.Features.Voters.Handlers
{
    public class CreateVoterHandler : BaseApiHandler<CreateVoterCommand, VoterDto>
    {
        public CreateVoterHandler(IAppDbContext dataContext) : base(dataContext)
        {
        }

        public override async Task<ApiResponse<VoterDto>> Handle(CreateVoterCommand request, CancellationToken cancellationToken)
        {
            var voter = new Voter(request.CreateVoterRequest.Name);
            var entry = await DataContext.Voters.AddAsync(voter, cancellationToken);
            await DataContext.SaveChanges(cancellationToken);
            var entity = entry.Entity;
            return Response(new VoterDto(entity.Id, entity.Name ?? ""));
        }
    }
}
