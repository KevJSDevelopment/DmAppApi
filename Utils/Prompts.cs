using System;
namespace DMApp.Utils
{
	public class Prompts
	{
		public static string CreateCharacter(object properties, string description = "Random")
		{
			return $"Use the description at the end of this prompt to create a D&D character by creating a json object with key value pairs that match the keys passed in from the properties. Replace all empty string values with values that match the description of the character but do not replace values that are not empty strings. Make sure each key and value is formatted with both an opening and closing double quote. Also make sure the object has an opening and closing curly bracket to make a proper json object. Description: {description}. Properties: {properties}.";
		}
	}
}

