using Football_Players_API.Features.NationalTeams.Query.GetNationalTeamDetail;
using Football_Players_API.Features.NationalTeams.Query.GetNationalTeams;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Controllers.NationalTeamController
{
    [Route("api/NationalTeams")]
    [ApiController]
    public class NationalTeamQueryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NationalTeamQueryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetNationalTeams()
        {
            var nationalTeams = await _mediator.Send(new GetNationalTeamsQuery());

            return nationalTeams == null ? NotFound() : Ok(nationalTeams);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNationalTeam(Guid id)
        {
            var nationalTeam = await _mediator.Send(new GetNationalTeamDetailQuery() { Id = id });

            return nationalTeam == null ? NotFound() : Ok(nationalTeam);
        }
    }
}
