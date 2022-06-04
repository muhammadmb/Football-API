using AutoMapper;
using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.NationalTeams.Commands.UpdateNationalTeam
{
    public class UpdateNationalTeamCommandHandler : IRequestHandler<UpdateNationalTeamCommand>
    {

        private readonly INationalTeamRepository _nationalTeamRepository;
        private readonly IMapper _mapper;

        public UpdateNationalTeamCommandHandler(INationalTeamRepository nationalTeamRepository, IMapper mapper)
        {
            _nationalTeamRepository = nationalTeamRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateNationalTeamCommand request, CancellationToken cancellationToken)
        {
            var nationalTeamFromDb = await _nationalTeamRepository.GetByIdAsync(request.Id);

            var nationalTeam = _mapper.Map(request, nationalTeamFromDb);

            await _nationalTeamRepository.UpdateAsync(nationalTeam);

            return Unit.Value;
        }
    }
}
