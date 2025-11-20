using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public interface IVideoGameCharacterService
    {
        Task<List<Character>> GetAllCharactersAsync();
        Task<Character?> GetCharacterByIdAsync(int id);

        Task<Character> CreateCharacterAsync(Character character);

        Task<Character?> UpdateCharacterAsync(int id, Character character);

        Task<bool> DeleteCharacterAsync(int id);


    }
}
