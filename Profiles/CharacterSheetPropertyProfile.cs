using AutoMapper;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;

namespace DMApp.Profiles
{
    public class CharacterSheetPropertyProfile : Profile
    {

        public CharacterSheetPropertyProfile()
        {
            CreateMap<CharacterClass, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, CharacterClass>();
            CreateMap<CharacterRace, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, CharacterRace>();
            CreateMap<Feature, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, Feature>();
            CreateMap<Trait, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, Trait>();
            CreateMap<Organization, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, Organization>();
            CreateMap<Item, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, Item>();
            CreateMap<Spell, CharacterSheetPropertyDto>();
            CreateMap<CharacterSheetPropertyDto, Spell>();
        }
    }
}

