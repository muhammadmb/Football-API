using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Football_Players_API.Entities
{
    public class NationalTeam : GenericEntity
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

        public List<Player> Players { get; set; }
    }
}
