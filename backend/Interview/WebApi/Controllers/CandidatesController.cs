using Aplication.Features.Candidates.Commands;
using Aplication.Features.Candidates.Models;
using Aplication.Features.Candidates.Queries;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiVersion("1.0")]
    public class CandidatesController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await Mediator.Send(new GetCandidatesQuery());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCandidateRequest request)
        {
            var response = await Mediator.Send(new CreateCandidateCommand(request));
            return Ok(response);            
        }
    }
}
