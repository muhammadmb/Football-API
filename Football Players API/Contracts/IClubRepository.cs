using Football_Players_API.Entities;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Contracts
{
    public interface IClubRepository : IGenericRepository<Club>
    {
        public Task<Club> GetClubById(Guid id);
    }
}
