using Football_Players_API.AppContext;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football_Players_API.Repositories
{
    public class ClubPlayerRepository : GenericRepository<ClubPlayer>, IClubPlayerRepository
    {
        private readonly ApplicationContext _dbContext;

        public ClubPlayerRepository(ApplicationContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task AddClubPlayerRealtionship(List<ClubPlayer> clubPlayers)
        {
            clubPlayers.ForEach(c => _dbContext.ClubPlayers.Add(c));
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ClubPlayer>> GetPlayerClubs(Guid id)
        {
            return await _dbContext.ClubPlayers.Where(c => c.PlayerId == id).ToListAsync();
        }

        public async Task UpdateClubPlayerRealtionship(List<ClubPlayer> clubPlayers)
        {
            _dbContext.ClubPlayers.UpdateRange(clubPlayers);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteClubPlayerRealtionship(List<ClubPlayer> clubPlayers)
        {
            _dbContext.ClubPlayers.RemoveRange(clubPlayers);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteClubPlayerRealtionshipById(Guid id)
        {
            var clubPlayers = await _dbContext.ClubPlayers.Where(c => c.PlayerId == id).ToListAsync();
            clubPlayers.ForEach(c => _dbContext.ClubPlayers.Remove(c));
            await _dbContext.SaveChangesAsync();
        }
    }
}
