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

            string properties = JsonConvert.SerializeObject(characterReadDto, Formatting.Indented);
            string values = JsonConvert.SerializeObject(characterInitiateDto, Formatting.Indented);


            return $"Create a D&D character and fill out each of the following properties, making sure none of the values are null or empty:\n\n{properties}\n\n" +
                $"Provide values for each of the key properties listed above to complete the character's details while using and adding to the following starting details: {values}. \n\n" +
                $"Ensure the response is a JSON string with filled-out key/value pairs, representing the character's information.\n\n" +
                $"Example Output:\n\n{{\n  \"Property1\": \"Value1\",\n  \"Property2\": \"Value2\",\n  \"Property3\": \"Value3\"\n}}\n\n" +
                $"Please stay within the given token limit of {tokens} and ensure the response adheres to the specified format.";
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

