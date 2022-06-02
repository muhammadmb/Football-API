using Football_Players_API.AppContext;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Repositories
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        private readonly ApplicationContext _context;

        public PlayerRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _context = applicationContext;
        }

        public async Task<Player> GetPlayerById(Guid id)
        {
            return await _context.Players
                .Include(p => p.Clubs)
                .Include(p => p.NationalTeam)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            await _context.SaveChangesAsync();
        }

        public async Task<Player> AddPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }
    }
}
