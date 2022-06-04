using System;

namespace Football_Players_API.Modles.Club
{
    public class ClubsQueryDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Founded { get; set; }

        public string Logo { get; set; }

        public string Country { get; set; }
    }
}
