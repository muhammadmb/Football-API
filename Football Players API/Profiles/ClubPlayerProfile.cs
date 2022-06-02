using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Modles.ClubPlayer;

namespace Football_Players_API.Profiles
{
    public class ClubPlayerProfile : Profile
    {
        public ClubPlayerProfile()
        {
            CreateMap<ClubPlayer, CreateClubPlayerDto>().ReverseMap();
            CreateMap<ClubPlayer, UpdateClubPlayerDto>().ReverseMap();
        }
    }
}
