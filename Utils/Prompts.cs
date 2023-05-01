using System;
namespace DMApp.Utils
{
	public class Prompts
	{
		public static string CreateCharacter(object properties, string description = "Random")
		{
			return $"Use this description to create a D&D character by creating a json object with key value pairs. Description: {description} \n The keys should match each of the following properties and replace empty values: {properties}.";
		}
	}
}

