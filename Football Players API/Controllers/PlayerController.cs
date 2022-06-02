using Football_Players_API.Features.Players.Commands.CreatePlayer;
using Football_Players_API.Features.Players.Commands.DeletePlayer;
using Football_Players_API.Features.Players.Commands.UpdatePlayer;
using Football_Players_API.Features.Players.Query.GetPlayerDetail;
using Football_Players_API.Features.Players.Query.GetPlayers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Football_Players_API.Controllers
{
    [Route("api/Players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllPlayers")]
        public async Task<ActionResult<List<GetPlayersQuery>>> GetPlayers()
        {
            var players = await _mediator.Send(new GetPlayersQuery());

            return players == null ? NotFound() : Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<GetPlayerDetailQuery>>> GetPlayerById(Guid id)
        {
            var getEvemtDetailQuery = new GetPlayerDetailQuery() { Id = id };

            var player = await _mediator.Send(getEvemtDetailQuery);

            return player == null ? NotFound() : Ok(player);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer([FromBody] CreatePlayerCommand createPlayerCommand)
        {
            Guid id = await _mediator.Send(createPlayerCommand);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditPlayer([FromBody] UpdatePlayerCommand updatePlayerCommand)
        {
            await _mediator.Send(updatePlayerCommand);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deletePlayerCommand = new DeletePlayerCommand() { Id = id };
            await _mediator.Send(deletePlayerCommand);
            return NoContent();
        }
    }
}
