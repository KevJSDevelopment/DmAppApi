using System;
using DMApp.Dtos;
using Newtonsoft.Json;

namespace DMApp.Utils
{
	public class Prompts
	{
		public static string CreateCharacter(string input)
		{
			CharacterReadDto characterReadDto = new CharacterReadDto();

			string properties = JsonConvert.SerializeObject(characterReadDto);

			return $"Using these input properties: {input}, " +
				$"create a D&D character and enter values for the character using key value pair formatting using the following keys: {properties}. " +
				$"Replace values that are 'any' or empty with a value for the given key that makes sense based on the rest of the character properties. " +
				$"Make sure to write a paragraph or two for the background of the character.";
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

