using AutoMapper;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Football_Players_API.Features.NationalTeams.Commands.CreateNationalTeam
{
    public class CreateNationalTeamCommandHandler : IRequestHandler<CreateNationalTeamCommand, Guid>
    {
        private readonly INationalTeamRepository _nationalTeamRepository;
        private readonly IMapper _mapper;

        public CreateNationalTeamCommandHandler(INationalTeamRepository nationalTeamRepository, IMapper mapper)
        {
            _nationalTeamRepository = nationalTeamRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateNationalTeamCommand request, CancellationToken cancellationToken)
        {
            var nationalTeam = _mapper.Map<NationalTeam>(request);
            await _nationalTeamRepository.AddAsync(nationalTeam);
            return nationalTeam.Id;
        }
    }
}
