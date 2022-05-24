using MediatR;
using System;

namespace Football_Players_API.Features.Players.Commands.DeletePlayer
{
    public class DeletePlayerCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
