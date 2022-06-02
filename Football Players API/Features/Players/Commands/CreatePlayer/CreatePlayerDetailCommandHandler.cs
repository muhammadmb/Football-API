using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Commands.CreatePlayer
{
    public class CreatePlayerDetailCommandHandler : IRequestHandler<CreatePlayerCommand, Guid>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IClubPlayerRepository _clubPlayerRepository;
        private readonly IMapper _mapper;

        public CreatePlayerDetailCommandHandler(IPlayerRepository playerRepository, IClubPlayerRepository clubPlayerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _clubPlayerRepository = clubPlayerRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = _mapper.Map<Player>(request);
            player = await _playerRepository.AddPlayer(player);

            var clubPlayer = _mapper.Map<List<ClubPlayer>>(request.Clubs);
            clubPlayer.ForEach(c => c.PlayerId = player.Id);
            await _clubPlayerRepository.AddClubPlayerRealtionship(clubPlayer);

            return player.Id;
        }
    }
}
