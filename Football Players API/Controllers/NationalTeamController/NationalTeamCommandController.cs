using Football_Players_API.Features.NationalTeams.Commands.CreateNationalTeam;
using Football_Players_API.Features.NationalTeams.Commands.DeleteNationalTeam;
using Football_Players_API.Features.NationalTeams.Commands.UpdateNationalTeam;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Football_Players_API.Controllers.NationalTeamController
{
    [Route("api/NationalTeams")]
    [ApiController]
    public class NationalTeamCommandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NationalTeamCommandController(IMediator mediator)
        {
            _mediator = mediator; 
        }

        [HttpPost]
        public async Task<IActionResult> AddNationalTeam([FromBody] CreateNationalTeamCommand createNationalTeam)
        {
            var NationalTeamId = await _mediator.Send(createNationalTeam);

            return Ok(NationalTeamId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditNationalTeam([FromBody] UpdateNationalTeamCommand updateNationalTeam)
        {
            await _mediator.Send(updateNationalTeam);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNationaTeam([FromBody] DeleteNationalTeamCommand deleteNationalTeam)
        {
            await _mediator.Send(deleteNationalTeam);
            return NoContent();
        }
    }
}
