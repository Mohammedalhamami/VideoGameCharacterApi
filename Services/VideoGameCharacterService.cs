using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {

      static List<Character> characters = new()
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros", Rule = "Jump on enemies to defeat them." },
            new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Rule = "Use your sword and shield to protect Hyrule." },
            new Character { Id = 3, Name = "Lara Croft", Game = "Tomb Raider", Rule = "Explore ancient tombs and solve puzzles." }
        };
        public Task<Character> CreateCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {

            var character = characters.FirstOrDefault(c => c.Id == id);

            return Task.FromResult(characters.Remove(character));
        }

        public async Task<List<Character>> GetAllCharactersAsync() => await Task.FromResult(characters);
        

        public  Task<Character?> GetCharacterByIdAsync(int id)
        {
           return  Task.FromResult(characters.FirstOrDefault(c => c.Id == id));
        }

        public Task<Character?> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
