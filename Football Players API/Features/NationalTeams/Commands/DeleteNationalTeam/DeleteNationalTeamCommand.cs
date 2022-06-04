using MediatR;
using System;

namespace Football_Players_API.Features.NationalTeams.Commands.DeleteNationalTeam
{
    public class DeleteNationalTeamCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
