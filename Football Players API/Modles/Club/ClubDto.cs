using System;

namespace Football_Players_API.Modles.Club
{
    public class ClubDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Country { get; set; }

        public DateTime DateOfJoin { get; set; }

        public DateTime DateOfContractEnd { get; set; }
    }
}
