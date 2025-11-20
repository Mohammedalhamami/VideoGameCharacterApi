using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoGameCharacterController(IVideoGameCharacterService service) : ControllerBase
    {
  
            private readonly IVideoGameCharacterService _service = service;


        [HttpGet(Name = "GetCharacters")]
        public async Task<ActionResult<Character>> GetCharacters() => Ok(await _service.GetAllCharactersAsync());


        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterById(int id)
        {
            var character = await _service.GetCharacterByIdAsync(id);
            return character is null ? NotFound($"Character with this id = {id} not found") : Ok(character);
           
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            var deleted = await _service.DeleteCharacterAsync(id);
            return deleted ? Ok($"Character with id = {id} deleted") : NotFound($"Character with id = {id} not found");
        }

    }
}
