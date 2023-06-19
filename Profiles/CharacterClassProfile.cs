using AutoMapper;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Profiles
{
    public class CharacterClassProfile : Profile
    {

        public CharacterClassProfile()
        {
            CreateMap<CharacterClass, CharacterClassDto>();
            CreateMap<CharacterClassDto, CharacterClass>();
        }
    }
}

