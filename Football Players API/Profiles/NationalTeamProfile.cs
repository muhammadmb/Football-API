using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Features.NationalTeams.Commands.CreateNationalTeam;
using Football_Players_API.Features.NationalTeams.Commands.DeleteNationalTeam;
using Football_Players_API.Features.NationalTeams.Commands.UpdateNationalTeam;
using Football_Players_API.Modles.NationalTeam;

namespace Football_Players_API.Profiles
{
    public class NationalTeamProfile : Profile
    {
        public NationalTeamProfile()
        {
            CreateMap<NationalTeam, NationalTeamDto>().ReverseMap();
            CreateMap<NationalTeam, NationalTeamDetailDto>().ReverseMap();
            CreateMap<NationalTeam, CreateNationalTeamCommand>().ReverseMap();
            CreateMap<NationalTeam, DeleteNationalTeamCommand>().ReverseMap();
            CreateMap<NationalTeam, UpdateNationalTeamCommand>().ReverseMap();
        }
    }
}
