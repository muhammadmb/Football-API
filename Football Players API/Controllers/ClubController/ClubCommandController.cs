using Football_Players_API.Features.Clubs.Commands.CreateClub;
using Football_Players_API.Features.Clubs.Commands.DeleteClub;
using Football_Players_API.Features.Clubs.Commands.UpdateClub;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Controllers.ClubController
{
    [Route("api/Clubs")]
    [ApiController]
    public class ClubCommandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClubCommandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddClub([FromBody] CreateClubCommand createClub)
        {
            var id = await _mediator.Send(createClub);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditClub([FromBody] UpdateClubCommand updateClub)
        {
            await _mediator.Send(updateClub);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClub(Guid id)
        {
            await _mediator.Send(new DeleteClubCommand { Id = id });

            return NoContent();
        }

    }
}
