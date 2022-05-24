﻿using Football_Players_API.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Football_Players_API.Features.Players.Commands.CreatePlayer
{
    public class CreatePlayerCommand : IRequest<Guid>
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Number { get; set; }

        [Url]
        public string Pictrue { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string Height { get; set; }

        [Required]
        public string Citizenship { get; set; }

        [Required]
        public string Position { get; set; }

        public int Goals { get; set; }

        public int Assists { get; set; }

        public Guid NationalTeamId { get; set; }
    }
}