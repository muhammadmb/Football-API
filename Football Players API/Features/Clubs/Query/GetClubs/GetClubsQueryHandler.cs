using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using Football_Players_API.Modles.Club;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Clubs.Query.GetClubs
{
    public class GetClubsQueryHandler : IRequestHandler<GetClubsQuery, List<ClubDto>>
    {
        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public GetClubsQueryHandler(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public async Task<List<ClubDto>> Handle(GetClubsQuery request, CancellationToken cancellationToken)
        {
            var clubs = await _clubRepository.GetAllAsync();

            return _mapper.Map<List<ClubDto>>(clubs);
        }
    }
}
