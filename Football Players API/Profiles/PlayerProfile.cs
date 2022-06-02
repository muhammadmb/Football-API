using AutoMapper;
using Football_Players_API.Entities;
using Football_Players_API.Features.Players.Commands.CreatePlayer;
using Football_Players_API.Features.Players.Commands.DeletePlayer;
using Football_Players_API.Features.Players.Commands.UpdatePlayer;
using Football_Players_API.Modles.Player;

namespace Football_Players_API.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, PlayerDto>()
                .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")
                );
            
            CreateMap<Player, PlayerDetailDto>()
                .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")
                );
            CreateMap<Player, CreatePlayerCommand>().ReverseMap();
            CreateMap<Player, UpdatePlayerCommand>().ReverseMap();
            CreateMap<Player, DeletePlayerCommand>().ReverseMap();
        }
    }
}
