using Football_Players_API.Features.Clubs.Query.GetClubDetail;
using Football_Players_API.Features.Clubs.Query.GetClubs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Controllers.ClubController
{
    [Route("api/Clubs")]
    [ApiController]
    public class ClubQueryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClubQueryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetClubs()
        {
            var clubs = await _mediator.Send(new GetClubsQuery());
            return clubs == null ? NotFound() : Ok(clubs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetClubById(Guid id)
        {
            var club = await _mediator.Send(new GetClubDetailQuery() { Id = id });
            return club == null ? NotFound() : Ok(club);
        }
    }
}
