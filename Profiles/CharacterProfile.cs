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
            CreateMap<Character, CharacterImageDto>();
            CreateMap<CharacterReadDto, CharacterImageDto>();
            CreateMap<CharacterReadDto, CharacterCreateDto>();
            CreateMap<CharacterCreateDto, Character>();
            CreateMap<CharacterCreateDto, CharacterReadDto>();
        }
    }
}
