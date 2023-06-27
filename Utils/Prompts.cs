using System;
using DMApp.Dtos;
using DMApp.Models;
using Newtonsoft.Json;

namespace DMApp.Utils
{
	public class Prompts
    {
        public static string CreateCharacter(CharacterInitiateDto characterInitiateDto, int tokens)
        {
            CharacterReadDto characterReadDto = new CharacterReadDto();

            string values = JsonConvert.SerializeObject(characterInitiateDto);
			string properties = JsonConvert.SerializeObject(characterReadDto);

			return $"Create a D&D character based on the following key value pair entries: {values}. " +
                $"Fill out additional values for the character for each of the following key properties: {properties}. " +
				$"Make sure the end result uses {tokens} tokens or less and only contains a json string with key value pairs for each of the key properties passed in but fill in all the values with values that would describe the character created. " +
                $"Lastly, make sure to write between a few sentences and a couple paragraphs in the Background key to tell a detailed story of the characters background. Do not go over the token limit";
		}

        public static string CreateCharacterImage(string properties)
        {
            List<string> wordsToAvoid = new List<string> { "child", "chest", "facial" };

            // Convert the list of words to a string
            string avoidString = string.Join(",", wordsToAvoid);

            return $"Create an optimized prompt for a text to image ai model to create an image for the character identified at the end of this prompt." +
				$"The character is identified in a json string listing each of the character properties." +
                $"Make sure the optimized prompt avoids using, removes, or replaces any of the following words to avoid TOS violations to the text to image ai model. " +
                $"Words to avoid: {avoidString}" +
                $"Identify the start of the prompt by adding an $ before the prompt starts. " +
				$"Here is the character that will be used to generate the prompt: {properties}";
		}
    }
}

