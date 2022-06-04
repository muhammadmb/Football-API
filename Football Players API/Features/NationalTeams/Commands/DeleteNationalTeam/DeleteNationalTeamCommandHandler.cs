using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.NationalTeams.Commands.DeleteNationalTeam
{
    public class DeleteNationalTeamCommandHandler : IRequestHandler<DeleteNationalTeamCommand>
    {
        private readonly INationalTeamRepository _nationalTeamRepository;

        public DeleteNationalTeamCommandHandler(INationalTeamRepository nationalTeamRepository)
        {
            _nationalTeamRepository = nationalTeamRepository;
        }

        public async Task<Unit> Handle(DeleteNationalTeamCommand request, CancellationToken cancellationToken)
        {
            var nationalTeam = await _nationalTeamRepository.GetByIdAsync(request.Id);

            await _nationalTeamRepository.DeleteAsync(nationalTeam);

            return Unit.Value;
        }
    }
}
