using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Football_Players_API.Features.Clubs.Commands.CreateClub
{
    public class CreateClubCommand : IRequest<Guid>
    {
        [Required]
        public string Name { get; set; }

        public DateTime Founded { get; set; }

        public int NumberOfTitles { get; set; }

        public int SquadSize { get; set; }

        [Url]
        public string Logo { get; set; }

        public string Stadium { get; set; }

        public string Country { get; set; }
    }
}
