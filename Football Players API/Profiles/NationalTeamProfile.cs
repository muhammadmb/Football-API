using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Modles.NationalTeam;

namespace Football_Players_API.Profiles
{
    public class NationalTeamProfile : Profile
    {
        public NationalTeamProfile()
        {
            CreateMap<NationalTeam, NationalTeamDto>().ReverseMap();
        }
    }
}
