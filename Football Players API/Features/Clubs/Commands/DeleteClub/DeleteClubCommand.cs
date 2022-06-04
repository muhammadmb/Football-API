using MediatR;
using System;

namespace Football_Players_API.Features.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
