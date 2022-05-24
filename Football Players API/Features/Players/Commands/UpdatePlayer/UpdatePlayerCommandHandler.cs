using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Commands.UpdatePlayer
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public UpdatePlayerCommandHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = _mapper.Map<Player>(request);

            await _playerRepository.UpdateAsync(player);

            return Unit.Value;
        }
    }
}
