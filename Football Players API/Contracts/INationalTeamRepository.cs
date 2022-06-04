using Football_Players_API.Entities;
using System;
using System.Threading.Tasks;

namespace Football_Players_API.Contracts
{
    public interface INationalTeamRepository: IGenericRepository<NationalTeam>
    {
        Task<NationalTeam> GetNationalTeamById(Guid id);
    }
}
