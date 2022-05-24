using AutoMapper;
using Football_Players_API.Modles.Player;
using Football_Players_API.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Query.GetPlayers
{
    public class GetPlayersQueryHandler : IRequestHandler<GetPlayersQuery, List<PlayerDto>>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public GetPlayersQueryHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<List<PlayerDto>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
        {
            var players = await _playerRepository.GetAllAsync();
            return _mapper.Map<List<PlayerDto>>(players);
        }
    }
}
