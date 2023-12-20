using System;
using AutoMapper;
using Azure;
using DMApp.Data;
using DMApp.Dtos;
using DMApp.Models;
using DMApp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using RestSharp;

namespace DMApp.Controllers
{
	public class CharacterTokenController : Controller
	{
        private readonly ICharacterTokenRepo _repository;
        private readonly IMapper _mapper;
        private readonly string? _neural_love_token;
        private readonly OpenAIAPI _api;

        public CharacterTokenController(ICharacterTokenRepo repository, IMapper mapper)
		{
            string? openai_key = Environment.GetEnvironmentVariable("OpenAI_Key");
            string? openai_org = Environment.GetEnvironmentVariable("OpenAi_Organization");
            _repository = repository;
            _mapper = mapper;
            _neural_love_token = Environment.GetEnvironmentVariable("Neural_Love_Token");
            _api = new OpenAIAPI(new APIAuthentication(openai_key, openai_org));
        }

        [HttpPost("/tokens/new/{characterId}")]
        public async Task<ActionResult> GenerateCharacterImages(int characterId)
        {
            Character character = _repository.GetCharacterById(characterId);
            CharacterImageDto characterImageDto = _mapper.Map<CharacterImageDto>(character);

            var properties = JsonConvert.SerializeObject(characterImageDto);

            try
            {
                var orderClient = new RestClient("https://api.neural.love/v1/ai-art/generate");
                var orderRequest = new RestSharp.RestRequest("/", method: Method.Post);
                orderRequest.AddHeader("accept", "application/json");
                orderRequest.AddHeader("content-type", "application/json");
                orderRequest.AddHeader("authorization", $"Bearer {_neural_love_token}");
                // Create the prompt JSON object using the character properties
                string createImagePrompt = new Prompts(_mapper).CreateCharacterImage(properties);

                ChatResult chatResponse = await _api.Chat.CreateChatCompletionAsync(new ChatRequest()
                {
                    Model = Model.ChatGPTTurbo,
                    Temperature = 0.1,
                    MaxTokens = 250,
                    Messages = new ChatMessage[] {
                        new ChatMessage(ChatMessageRole.User, createImagePrompt)
                    }
                });

                string response = chatResponse.Choices[0].Message.Content.ToString();

                string prompt = response.Substring(response.IndexOf('$') + 1).Trim();

                var promptObject = new
                {
                    style = "anything",
                    layout = "square",
                    amount = 4,
                    isPublic = true,
                    isPriority = false,
                    isHd = false,
                    steps = 25,
                    cfgScale = 7.5,
                    prompt = prompt // Use the character properties as the prompt
                };

                // Serialize the prompt object to JSON and set it as the request body
                string requestBody = JsonConvert.SerializeObject(promptObject);
                orderRequest.AddParameter("application/json", requestBody, ParameterType.RequestBody);


                RestSharp.RestResponse orderResponse = await orderClient.ExecuteAsync(orderRequest);

                if (orderResponse.IsSuccessful)
                {

                    JObject jsonObject = JObject.Parse(orderResponse.Content);

                    // Get the orderId value
                    string orderId = (string)jsonObject["orderId"];

                    RestSharp.RestResponse imagesResponse = new RestResponse();
                    JObject imagesObject = new JObject();
                    var imagesClient = new RestClient($"https://api.neural.love/v1/ai-art/orders/{orderId}");
                    var imagesRequest = new RestRequest("/", method: Method.Get);
                    imagesRequest.AddHeader("accept", "application/json");
                    imagesRequest.AddHeader("authorization", $"Bearer {_neural_love_token}");
                    bool isReady = false;
                    while (!isReady)
                    {
                        imagesResponse = await imagesClient.ExecuteAsync(imagesRequest);
                        imagesObject = JObject.Parse(imagesResponse.Content);
                        isReady = (bool)imagesObject["status"]["isReady"];
                        // Sleep for a certain duration before checking again
                        await Task.Delay(1000); // Wait for 1 second before checking again
                    }
                    return Ok(imagesObject);
                }
                else return BadRequest(new { error = orderResponse.ErrorMessage });

            } catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("/tokens/{characterId}")]
        public ActionResult<IList<CharacterToken>> GetCharacterTokens(int characterId)
        {
            Character character = _repository.GetCharacterById(characterId);
            IList<CharacterToken> tokens = _repository.GetSimilarCharacterTokens(character);

            return Ok(tokens);
        }
    }
}

