using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommandHandler : IRequestHandler<DeleteClubCommand>
    {
        private readonly IClubRepository _clubRepository;

        public DeleteClubCommandHandler(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public async Task<Unit> Handle(DeleteClubCommand request, CancellationToken cancellationToken)
        {
            var club = await _clubRepository.GetByIdAsync(request.Id);

            await _clubRepository.DeleteAsync(club);

            return Unit.Value;
        }
    }
}
