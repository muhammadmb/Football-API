using System;

namespace Football_Players_API.Modles.Player
{
    public class PlayerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public string Pictrue { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Citizenship { get; set; }

        public string Position { get; set; }
    }
}
