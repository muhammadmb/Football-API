using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Modles.NationalTeam;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.NationalTeams.Query.GetNationalTeams
{
    public class GetNationalTeamsQueryHandler : IRequestHandler<GetNationalTeamsQuery, List<NationalTeamDto>>
    {

        private readonly INationalTeamRepository _nationalTeamRepository;
        private readonly IMapper _mapper;

        public GetNationalTeamsQueryHandler(INationalTeamRepository nationalTeamRepository, IMapper mapper)
        {
            _nationalTeamRepository = nationalTeamRepository;
            _mapper = mapper;
        }

        public async Task<List<NationalTeamDto>> Handle(GetNationalTeamsQuery request, CancellationToken cancellationToken)
        {
            var nationalTeams = await _nationalTeamRepository.GetAllAsync();

            return _mapper.Map<List<NationalTeamDto>>(nationalTeams);
        }
    }
}
