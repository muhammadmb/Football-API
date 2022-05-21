using System;

namespace Football_Players_API.Entities
{
    public class ClubPlayer
    {
        public Guid PlayerId { get; set; }

        public Guid ClubId { get; set; }

        public Player Player { get; set; }

        public Club Club { get; set; }

        public DateTime DateOfJoin { get; set; }

        public DateTime DateOfContractEnd { get; set; }
    }
}
