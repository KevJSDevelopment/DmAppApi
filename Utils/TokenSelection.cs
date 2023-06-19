using System;
using DMApp.Models;

namespace DMApp
{
	public class TokenSelection
	{
        public static double CalculateSimilarity(Character? character1, Character? character2)
        {
            // Define weights for each property
            double weightSkin = 4;
            double weightEyes = 3;
            double weightHair = 2;
            double weightClass = 1;
            double weightBackground = 1;
            double weightTokenUsageCount = 1;

            // Calculate individual property similarities
            double skinSimilarity = CalculatePropertySimilarity(character1.Skin, character2.Skin);
            double eyesSimilarity = CalculatePropertySimilarity(character1.Eyes, character2.Eyes);
            double hairSimilarity = CalculatePropertySimilarity(character1.Hair, character2.Hair);
            double classSimilarity = CalculatePropertySimilarity(character1.Class.Name, character2.Class.Name);
            double BackgroundSimilarity = CalculatePropertySimilarity(character1.Background, character2.Background);

            // Calculate token usage count similarity (inverse score)
            double tokenUsageCountSimilarity = 1.0 / (1 + Math.Abs(character1.Token.Characters.Count - character2.Token.Characters.Count));

            // Calculate weighted sum of similarities
            double overallSimilarity = (weightSkin * skinSimilarity)
                + (weightEyes * eyesSimilarity)
                + (weightHair * hairSimilarity)
                + (weightClass * classSimilarity)
                + (weightBackground * BackgroundSimilarity)
                + (weightTokenUsageCount * tokenUsageCountSimilarity);

            return overallSimilarity;
        }

        private static double CalculatePropertySimilarity(string? property1, string? property2)
        {
            // Implement property similarity calculation logic here
            // Compare the properties and assign a similarity score
            if (property1 == null || property2 == null) return 0.0;

            // Example: Calculate similarity based on exact match or Levenshtein distance
            if (property1 == property2)
            {
                return 1.0; // Exact match
            }
            else
            {
                // Calculate Levenshtein distance and assign a score based on similarity threshold
                int distance = CalculateLevenshteinDistance(property1, property2);
                double similarity = 1.0 - (distance / (double)Math.Max(property1.Length, property2.Length));
                double similarityThreshold = 0.8; // Adjust as needed
                return similarity >= similarityThreshold ? similarity : 0.0;
            }
        }

        private static int CalculateLevenshteinDistance(string? str1, string? str2)
        {
            // Implement Levenshtein distance calculation logic here
            // Calculate the minimum number of operations (insertions, deletions, substitutions)
            // required to transform str1 into str2

            // Example: Levenshtein distance calculation using dynamic programming
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i <= str1.Length; i++)
                dp[i, 0] = i;

            for (int j = 0; j <= str2.Length; j++)
                dp[0, j] = j;

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    int cost = str1[i - 1] == str2[j - 1] ? 0 : 1;
                    dp[i, j] = Math.Min(
                        dp[i - 1, j] + 1,
                        Math.Min(dp[i, j - 1] + 1, dp[i - 1, j - 1] + cost)
                    );
                }
            }

            return dp[str1.Length, str2.Length];
        }
    }
}

