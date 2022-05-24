using Football_Players_API.Modles.Player;
using MediatR;
using System.Collections.Generic;

namespace Football_Players_API.Features.Players.Query.GetPlayers
{
    public class GetPlayersQuery : IRequest<List<PlayerDto>>
    {

    }
}
