using Football_Players_API.Modles.Player;
using System;
using System.Collections.Generic;

namespace Football_Players_API.Modles.Club
{
    public class ClubDetailDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Founded { get; set; }

        public int NumberOfTitles { get; set; }

        public int SquadSize { get; set; }

        public string Logo { get; set; }

        public string Stadium { get; set; }

        public string Country { get; set; }

        public List<PlayerDto> Players { get; set; }
    }
}
