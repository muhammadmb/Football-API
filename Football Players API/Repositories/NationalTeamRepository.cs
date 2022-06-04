using Football_Players_API.AppContext;
using Football_Players_API.Contracts;
using Football_Players_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Repositories
{
    public class NationalTeamRepository : GenericRepository<NationalTeam>, INationalTeamRepository
    {
        private readonly ApplicationContext _context;

        public NationalTeamRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<NationalTeam> GetNationalTeamById(Guid id)
        {
            var nationalTeam = await _context.NationalTeams.Include(n => n.Players).FirstOrDefaultAsync(n => n.Id == id);

            return nationalTeam;
        }
    }
}
