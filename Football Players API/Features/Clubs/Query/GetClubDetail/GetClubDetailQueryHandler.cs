using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Modles.Club;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Clubs.Query.GetClubDetail
{
    public class GetClubDetailQueryHandler : IRequestHandler<GetClubDetailQuery, ClubDetailDto>
    {
        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public GetClubDetailQueryHandler(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public async Task<ClubDetailDto> Handle(GetClubDetailQuery request, CancellationToken cancellationToken)
        {
            var club = await _clubRepository.GetClubById(request.Id);

            var returnClub = _mapper.Map<ClubDetailDto>(club);

            return returnClub;
        }
    }
}
