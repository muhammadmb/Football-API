using Football_Players_API.Modles.Club;
using MediatR;
using System.Collections.Generic;

namespace Football_Players_API.Features.Clubs.Query.GetClubs
{
    public class GetClubsQuery : IRequest<List<ClubsQueryDto>>
    {
    }
}
