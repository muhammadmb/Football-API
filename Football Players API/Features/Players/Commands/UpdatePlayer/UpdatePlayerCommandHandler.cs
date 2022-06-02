using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Commands.UpdatePlayer
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IClubPlayerRepository _clubPlayerRepository;
        private readonly IMapper _mapper;

        public UpdatePlayerCommandHandler(IPlayerRepository playerRepository, IClubPlayerRepository clubPlayerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _clubPlayerRepository = clubPlayerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
        {
            var playerFromDb = await _playerRepository.GetPlayerById(request.Id);

            _mapper.Map(request, playerFromDb);

            var clubPlayer = _mapper.Map<List<ClubPlayer>>(request.Clubs);

            if (playerFromDb.Clubs.Count != 0)
            {
                await _clubPlayerRepository.DeleteClubPlayerRealtionshipById(playerFromDb.Id);
            }

            await _clubPlayerRepository.AddClubPlayerRealtionship(clubPlayer);

            await _playerRepository.UpdatePlayer(playerFromDb);

            return Unit.Value;
        }
    }
}
