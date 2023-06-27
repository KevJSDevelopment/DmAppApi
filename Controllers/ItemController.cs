using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class ItemConroller : Controller
	{
        private readonly IItemRepo _itemRepo;
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public ItemConroller(IItemRepo itemRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpPost("/Items/{guildId}")]
        public ActionResult CreateItem([FromBody] CharacterSheetPropertyDto itemDto, long guildId = 1077311704985239684)
        {
            Item item = _mapper.Map<Item>(itemDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            item.Guilds.Add(guild);

            _itemRepo.CreateItem(item);

            return Ok("Item Created");
        }
    }
}

