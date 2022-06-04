using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Clubs.Commands.CreateClub
{
    public class CreateClubCommandHandler : IRequestHandler<CreateClubCommand, Guid>
    {

        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public CreateClubCommandHandler(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateClubCommand request, CancellationToken cancellationToken)
        {
            var club = _mapper.Map<Club>(request);

            await _clubRepository.AddAsync(club);

            return club.Id;
        }
    }
}
