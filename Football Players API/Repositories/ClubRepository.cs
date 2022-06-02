using Football_Players_API.AppContext;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Repositories
{
    public class ClubRepository : GenericRepository<Club>, IClubRepository
    {
        private readonly ApplicationContext _context;

        public ClubRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Club> GetClubById(Guid id)
        {
            var club = await _context.Clubs.Include(c => c.Players).FirstOrDefaultAsync(c => c.Id == id);

            return club;
        }
    }
}
