using Football_Players_API.Modles.NationalTeam;
using MediatR;
using System.Collections.Generic;

namespace Football_Players_API.Features.NationalTeams.Query.GetNationalTeams
{
    public class GetNationalTeamsQuery : IRequest<List<NationalTeamDto>>
    {
    }
}
