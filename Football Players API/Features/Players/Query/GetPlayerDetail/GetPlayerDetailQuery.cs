using Football_Players_API.Modles.Player;
using MediatR;
using System;

namespace Football_Players_API.Features.Players.Query.GetPlayerDetail
{
    public class GetPlayerDetailQuery : IRequest<PlayerDetailDto>
    {
        public Guid Id { get; set; }
    }
}
