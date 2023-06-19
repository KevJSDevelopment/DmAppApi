using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Profiles
{
    public class CharacterRaceProfile : Profile
    {

        public CharacterRaceProfile()
        { 
            CreateMap<CharacterRace, CharacterRaceDto>();
            CreateMap<CharacterRaceDto, CharacterRace>();
        }
    }
}
