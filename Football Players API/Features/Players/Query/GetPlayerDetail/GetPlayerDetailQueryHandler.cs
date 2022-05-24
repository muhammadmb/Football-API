using AutoMapper;
using Football_Players_API.Modles.Player;
using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Query.GetPlayerDetail
{
    public class GetPlayerDetailQueryHandler : IRequestHandler<GetPlayerDetailQuery, PlayerDetailDto>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public GetPlayerDetailQueryHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<PlayerDetailDto> Handle(GetPlayerDetailQuery request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.GetByIdAsync(request.Id);

            return _mapper.Map<PlayerDetailDto>(player);
        }
    }
}
