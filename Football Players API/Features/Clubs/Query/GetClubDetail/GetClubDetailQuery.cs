using Football_Players_API.Modles.Club;
using MediatR;
using System;

namespace Football_Players_API.Features.Clubs.Query.GetClubDetail
{
    public class GetClubDetailQuery : IRequest<ClubDetailDto>
    {
        public Guid Id { get; set; }
    }
}
