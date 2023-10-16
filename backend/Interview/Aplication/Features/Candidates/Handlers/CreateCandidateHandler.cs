using Aplication.Abstractions.Handlers;
using Aplication.Abstractions;
using Aplication.Interfaces;
using Aplication.Features.Candidates.Models;
using Aplication.Features.Candidates.Commands;
using Domain.Entites;

namespace Aplication.Features.Candidates.Handlers
{
    public class CreateCandidateHandler : BaseApiHandler<CreateCandidateCommand, CandidateDto>
    {
        public CreateCandidateHandler(IAppDbContext dataContext) : base(dataContext)
        {

        }

        public override async Task<ApiResponse<CandidateDto>> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate = new Candidate(request.CreateCandidateRequest.Name);
            var entry = await DataContext.Candidates.AddAsync(candidate, cancellationToken);
            await DataContext.SaveChanges(cancellationToken);
            var entity = entry.Entity;
            return Response(new CandidateDto(entity.Id, entity.Name ?? ""));
        }
    }
}
