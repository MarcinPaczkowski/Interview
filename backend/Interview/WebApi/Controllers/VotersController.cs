using Aplication.Features.Voters.Commands;
using Aplication.Features.Voters.Models;
using Aplication.Features.Voters.Queries;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiVersion("1.0")]
    public class VotersController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await Mediator.Send(new GetVotersQuery());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVoterRequest request)
        {
            var response = await Mediator.Send(new CreateVoterCommand(request));
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Vote(VoteRequest request)
        {
            var response = await Mediator.Send(new VoteCommand(request));
            return Ok(response);
        }
    }
}