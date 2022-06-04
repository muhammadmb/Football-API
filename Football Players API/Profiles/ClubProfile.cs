using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Features.Clubs.Commands.CreateClub;
using Football_Players_API.Features.Clubs.Commands.UpdateClub;
using Football_Players_API.Modles.Club;

namespace Football_Players_API.Profiles
{
    public class ClubProfile : Profile
    {
        public ClubProfile()
        {
            CreateMap<Club, ClubDto>().ReverseMap(); 
            CreateMap<Club, ClubsQueryDto>().ReverseMap();
            CreateMap<Club, ClubDetailDto>().ReverseMap();
            CreateMap<Club, CreateClubCommand>().ReverseMap();
            CreateMap<Club, UpdateClubCommand>().ReverseMap();
        }
    }
}
