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

        private readonly IMapper _mapper;

        public ItemConroller(IItemRepo itemRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            
            _mapper = mapper;
        }

        [HttpPost("/Items")]
        public ActionResult CreateItem([FromBody] CharacterSheetPropertyDto itemDto)
        {
            Item item = _mapper.Map<Item>(itemDto);
            
            _itemRepo.CreateItem(item);

            return Ok("Item Created");
        }
    }
}

