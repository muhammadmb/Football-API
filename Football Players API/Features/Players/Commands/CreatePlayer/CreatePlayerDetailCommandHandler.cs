using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Commands.CreatePlayer
{
    public class CreatePlayerDetailCommandHandler: IRequestHandler<CreatePlayerCommand, Guid>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public CreatePlayerDetailCommandHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = _mapper.Map<Player>(request);

            player = await _playerRepository.AddAsync(player);

            return player.Id;
        }
    }
}
