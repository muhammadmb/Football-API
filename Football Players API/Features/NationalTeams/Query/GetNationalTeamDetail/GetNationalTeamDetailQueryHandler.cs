using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Modles.NationalTeam;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.NationalTeams.Query.GetNationalTeamDetail
{
    public class GetNationalTeamDetailQueryHandler : IRequestHandler<GetNationalTeamDetailQuery, NationalTeamDetailDto>
    {
        private readonly INationalTeamRepository _nationalTeamRepository;
        private readonly IMapper _mapper;

        public GetNationalTeamDetailQueryHandler(INationalTeamRepository nationalTeamRepository, IMapper mapper)
        {
            _nationalTeamRepository = nationalTeamRepository;
            _mapper = mapper;
        }

        public async Task<NationalTeamDetailDto> Handle(GetNationalTeamDetailQuery request, CancellationToken cancellationToken)
        {
            var nationalTeam = await _nationalTeamRepository.GetNationalTeamById(request.Id);

            return _mapper.Map<NationalTeamDetailDto>(nationalTeam);
        }
    }
}
