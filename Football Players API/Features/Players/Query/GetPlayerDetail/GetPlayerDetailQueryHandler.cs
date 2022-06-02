using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Modles.Club;
using Football_Players_API.Modles.Player;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Query.GetPlayerDetail
{
    public class GetPlayerDetailQueryHandler : IRequestHandler<GetPlayerDetailQuery, PlayerDetailDto>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IClubPlayerRepository _clubPlayerRepository;
        private readonly IMapper _mapper;

        public GetPlayerDetailQueryHandler(IPlayerRepository playerRepository, IClubPlayerRepository clubPlayerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _clubPlayerRepository = clubPlayerRepository;
            _mapper = mapper;
        }

        public async Task<PlayerDetailDto> Handle(GetPlayerDetailQuery request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.GetPlayerById(request.Id);

            var returnPlayer = _mapper.Map<PlayerDetailDto>(player);

            if (player != null)
            {
                var clubPlayer = await _clubPlayerRepository.GetPlayerClubs(player.Id);

                var clubs = returnPlayer.Clubs.Join(clubPlayer, c => c.Id, cp => cp.ClubId, (c, cp) => new ClubDto
                {
                    Id = c.Id,
                    DateOfContractEnd = cp.DateOfContractEnd,
                    DateOfJoin = cp.DateOfJoin,
                    Name = c.Name,
                    Country = c.Country,
                    Logo = c.Logo
                }).ToList();

                returnPlayer.Clubs = clubs;
            }

            return returnPlayer;
        }
    }
}
