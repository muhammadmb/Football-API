using Football_Players_API.Entities;
using Football_Players_API.Modles.Club;
using Football_Players_API.Modles.NationalTeam;
using System;
using System.Collections.Generic;

namespace Football_Players_API.Modles.Player
{
    public class PlayerDetailDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public string Pictrue { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Citizenship { get; set; }

        public string Position { get; set; }

        public List<ClubDto> Clubs { get; set; }

        public NationalTeamDto NationalTeam { get; set; }
    }
}
