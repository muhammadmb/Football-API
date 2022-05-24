using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Modles.Club;

namespace Football_Players_API.Profiles
{
    public class ClubProfile : Profile
    {
        public ClubProfile()
        {
            CreateMap<Club, ClubDto>().ReverseMap();
        }
    }
}
