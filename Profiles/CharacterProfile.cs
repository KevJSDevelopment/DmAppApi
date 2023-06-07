using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Profiles
{
    public class CharacterProfile : Profile
    {

        public CharacterProfile()
        { 
            CreateMap<Character, CharacterReadDto>();
            CreateMap<CharacterReadDto, Character>();
            CreateMap<CharacterReadDto, CharacterImageDto>();
            CreateMap<Character, CharacterImageDto>();
        }
    }
}
