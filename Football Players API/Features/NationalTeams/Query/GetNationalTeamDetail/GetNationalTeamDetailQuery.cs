using Football_Players_API.Modles.NationalTeam;
using MediatR;
using System;

namespace Football_Players_API.Features.NationalTeams.Query.GetNationalTeamDetail
{
    public class GetNationalTeamDetailQuery : IRequest<NationalTeamDetailDto>
    {
        public Guid Id { get; set; }
    }
}
