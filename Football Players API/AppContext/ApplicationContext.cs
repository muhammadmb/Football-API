using Football_Players_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Football_Players_API.AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<NationalTeam> NationalTeams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<ClubPlayer> ClubPlayers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>()
                .HasOne(p => p.NationalTeam)
                .WithMany(i => i.Players)
                .HasForeignKey(p => p.NationalTeamId);

            modelBuilder.Entity<Player>()
                .HasMany(p => p.Clubs)
                .WithMany(c => c.Players)
                .UsingEntity<ClubPlayer>
                (cp => cp.HasOne(cp => cp.Club).WithMany().HasForeignKey(cp => cp.ClubId),
                cp => cp.HasOne(cp => cp.Player).WithMany().HasForeignKey(cp => cp.PlayerId));

            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000000"),
                    DateOfAdd = new DateTime(2022, 4, 5),
                    Founded = new DateTime(1907, 4, 24),
                    Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8c/Al_Ahly_SC_logo.png/130px-Al_Ahly_SC_logo.png",
                    Name = "Al Ahly Sporting Club",
                    NumberOfTitles = 107,
                    SquadSize = 30,
                    Stadium = "El-Ahly Stadium",
                    Country = "Egypt"
                },
                new Club
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000001"),
                    DateOfAdd = new DateTime(2022, 4, 5),
                    Founded = new DateTime(1886, 10, 5),
                    Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Arsenal_FC.svg/160px-Arsenal_FC.svg.png",
                    Name = "The Arsenal Football Club",
                    NumberOfTitles = 55,
                    SquadSize = 30,
                    Stadium = "Emirates Stadium",
                    Country = "England"
                });

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    FirstName = "Muhammad",
                    LastName = "Abou trika",
                    Assists = 120,
                    Goals = 140,
                    Citizenship = "Egyption",
                    DateOfAdd = new DateTime(2022, 4, 5),
                    DateOfBirth = new DateTime(1977, 5, 2),
                    Height = "185 cm",
                    Number = "22",
                    Position = "AMF",
                    NationalTeamId = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                    Pictrue = "https://3.bp.blogspot.com/-ktPnakamJXA/WIAHa0EvRaI/AAAAAAAAjmM/06w8jIgFP4UcmJQMfSOvYD10bHVNMUdoACLcB/s1600/Abou%2BTrika.jpg"
                },
                 new Player
                 {
                     Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                     FirstName = "Muhammad",
                     LastName = "barakat",
                     Assists = 100,
                     Goals = 80,
                     Citizenship = "Egyption",
                     DateOfAdd = new DateTime(2022, 4, 5),
                     DateOfBirth = new DateTime(1976, 5, 2),
                     Height = "175 cm",
                     Number = "11",
                     Position = "RW",
                     NationalTeamId = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                     Pictrue = "https://cdn.arageek.com/magazine/2017/09/Mohamed-Barakat-1.jpg"
                 }
                );

            modelBuilder.Entity<NationalTeam>().HasData(

                new NationalTeam
                {
                    Id = Guid.Parse("00000000-0000-0000-abcd-000000000002"),
                    DateOfAdd = new DateTime(2022, 4, 5),
                    Founded = new DateTime(1900, 10, 5),
                    Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Arsenal_FC.svg/160px-Arsenal_FC.svg.png",
                    Name = "Egyption national team",
                    NumberOfTitles = 9,
                    SquadSize = 30,
                    Stadium = "Cairo Stadium"
                });
        }
    }
}
