using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ICharacterTokenRepo
    {
        bool SaveChanges();
        CharacterToken GetToken(int tokenId);
        IList<Character> GetCharactersByTokenId(int tokenId);
        Character GetCharacterById(int characterId);
        IList<CharacterToken> GetSimilarCharacterTokens(Character character);
        void CreateToken(CharacterToken token);
        void UpdateToken(CharacterToken token);
        void DeleteToken(CharacterToken token);
    }
}