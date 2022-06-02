using System;

namespace Football_Players_API.Modles.ClubPlayer
{
    public class CreateClubPlayerDto
    {
        public Guid ClubId { get; set; }

        public DateTime DateOfJoin { get; set; }

        public DateTime DateOfContractEnd { get; set; }
    }
}
