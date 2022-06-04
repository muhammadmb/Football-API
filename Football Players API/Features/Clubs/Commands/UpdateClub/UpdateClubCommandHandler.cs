using AutoMapper;
using Football_Players_API.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.Clubs.Commands.UpdateClub
{
    public class UpdateClubCommandHandler : IRequestHandler<UpdateClubCommand>
    {
        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public UpdateClubCommandHandler(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateClubCommand request, CancellationToken cancellationToken)
        {
            var clubFromDb = await _clubRepository.GetByIdAsync(request.Id);

            var club = _mapper.Map(request, clubFromDb);

            await _clubRepository.UpdateAsync(club);

            return Unit.Value;
        }
    }
}
