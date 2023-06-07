using System;
using DMApp.Dtos;

namespace DMApp.Utils
{
	public class Prompts
	{
		public static string CreateCharacter(string properties)
		{
			return $"Create a D&D character by creating a json object with key value pairs that match the keys passed in from the properties. " +
				$"Replace all values that say 'any' with generated values that make sense for the character and that specific key. " +
				$"Make sure each key and value is formatted with both an opening and closing double quote. " +
				$"Also make sure the object has an opening and closing curly bracket to make a proper json object. " +
				$"If description is 'any' then make sure to write a paragraph or two about the character based on the other properties" +
				$"Properties: {properties}.";
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

