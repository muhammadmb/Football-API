﻿using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Football_Players_API.Features.NationalTeams.Commands.CreateNationalTeam
{
    public class CreateNationalTeamCommand : IRequest<Guid>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Founded { get; set; }

        public int NumberOfTitles { get; set; }

        public int SquadSize { get; set; }

        [Url]
        [Required]
        public string Logo { get; set; }

        public string Stadium { get; set; }
    }
}
