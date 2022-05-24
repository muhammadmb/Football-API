using AutoMapper;
using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Players.Commands.DeletePlayer
{
    public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public DeletePlayerCommandHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeletePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.GetByIdAsync(request.Id);

            await _playerRepository.DeleteAsync(player);

            return Unit.Value;
        }
    }
}
