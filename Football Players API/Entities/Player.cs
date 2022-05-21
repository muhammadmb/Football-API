using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Football_Players_API.Entities
{
    public class Player : GenericEntity
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

        public NationalTeam NationalTeam { get; set; }

        public List<Club> Clubs { get; set; }
    }
}
