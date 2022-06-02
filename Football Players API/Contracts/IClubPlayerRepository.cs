using Football_Players_API.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Football_Players_API.Contracts
{
    public interface IClubPlayerRepository : IGenericRepository<ClubPlayer>
    {
        Task AddClubPlayerRealtionship(List<ClubPlayer> clubPlayers);

        Task<List<ClubPlayer>> GetPlayerClubs(Guid id);

        Task UpdateClubPlayerRealtionship(List<ClubPlayer> clubPlayers);

        Task DeleteClubPlayerRealtionship(List<ClubPlayer> clubPlayers);

        Task DeleteClubPlayerRealtionshipById(Guid id);
    }
}
