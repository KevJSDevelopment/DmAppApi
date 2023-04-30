using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using DMApp.Models;
using AutoMapper;
using DMApp.Data;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.AcroForms;
using System.Net.Http;
using System.Threading.Tasks;
using DmApp;
using DMApp.Dtos;

namespace DMApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public CharacterController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> CreateCharacter([FromBody] dynamic data)
        {
            string message = data.message;
            try
            {
                // var response = await openai.CreateCompletionAsync(new CompletionRequest
                // {
                //     Model = "text-davinci-003",
                //     Prompt = $"{message}",
                //     MaxTokens = 1000,
                //     Temperature = 0
                // });

                // dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Choices[0].Text);
                // CharacterModel character = await CharacterModel.FindByIdAsync("63f15a8f5990d0403c791e9d");

                return Ok(); // Json(new { character });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<ActionResult> SaveCharacter([FromBody] dynamic data)
        {
            Character character = data.character.ToObject<Character>();
            //CharacterModel newChar = await CharacterModel.CreateAsync(character);
            return Json(new { character = character }); // change to newChar
        }

        [HttpPost]
        public async Task<ActionResult> GetCharacter([FromBody] dynamic data)
        {
            string name = data.name;
            int age = data.age;
            int height = data.height;
            int weight = data.weight;
            string eyes = data.eyes;
            string skin = data.skin;
            string hair = data.hair;
            string backstory = data.backstory;

            var characterReadDto = _mapper.Map<CharacterReadDto>(data);

            string pdfDataUri = await FileHelper.FillFormAsync(characterReadDto);

            return File(Convert.FromBase64String(pdfDataUri), "application/pdf", "CharacterSheet.pdf");
        }
    }
}

