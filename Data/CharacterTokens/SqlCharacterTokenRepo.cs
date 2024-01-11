using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DMApp.Data
{
    public class SqlCharacterTokenRepo : ICharacterTokenRepo
    {
        private readonly DMAppContext _context;

        public SqlCharacterTokenRepo(DMAppContext context)
        {
            _context = context;
        }

        public CharacterToken GetToken(int tokenId)
        {
            return _context.CharacterTokens.FirstOrDefault(t => t.Id == tokenId);
        }

        public void CreateToken(CharacterToken token)
        {
            if(token == null)
            {
                throw new ArgumentNullException(nameof(token));
            }

            _context.CharacterTokens.Add(token);
        }

        public void DeleteToken(CharacterToken token)
        {
            if(token == null)
            {
                throw new ArgumentNullException(nameof(token));
            }

            _context.CharacterTokens.Remove(token);
        }

        public void UpdateToken(CharacterToken token)
        {
            //Nothing
        }

        public bool SaveChanges()
        {
            // save changes to database, return true if successful or false if fails
            return (_context.SaveChanges() >= 0);
        }

        public IList<Character> GetCharactersByTokenId(int tokenId)
        {
            var characters = _context.Characters.Where(c => c.TokenId == tokenId).ToList();

            return characters;
        }

        public Character GetCharacterById(int characterId)
        {
            return _context.Characters.FirstOrDefault(c => c.Id == characterId);
        }

        public IList<CharacterToken> GetSimilarCharacterTokens(Character character)
        {
            // Calculate similarity scores for all tokens
            var tokens = _context.CharacterTokens
                .Include(t => t.Characters.Where(c => c.Race == character.Race))
                .ToList();

            // Calculate similarity scores for each token's characters
            var tokenScores = new Dictionary<CharacterToken, double>();
            foreach (var token in tokens)
            {
                double totalScore = 0;
                int characterCount = 0;

                // Calculate the total similarity score for each character of the token
                foreach (var tokenCharacter in token.Characters)
                {
                    double score = TokenSelection.CalculateSimilarity(character, tokenCharacter);
                    totalScore += score;
                    characterCount++;
                }

                // Calculate the average similarity score for the token's characters
                double averageScore = characterCount > 0 ? totalScore / characterCount : 0;

                // Store the average score for the token
                tokenScores[token] = averageScore;
            }

            // Select the top 25 tokens with the highest similarity scores
            var similarTokens = tokenScores
                .OrderByDescending(pair => pair.Value)
                .Take(25)
                .Select(pair => pair.Key)
                .ToList();

            // Return the list of similar tokens
            return similarTokens;
        }
    }
}