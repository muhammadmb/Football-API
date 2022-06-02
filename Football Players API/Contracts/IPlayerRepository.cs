using Football_Players_API.Entities;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Contracts
{
    public interface IPlayerRepository : IGenericRepository<Player>
    {
        Task UpdatePlayer(Player player);

        Task<Player> GetPlayerById(Guid id);

        Task<Player> AddPlayer(Player player);
    }
}
