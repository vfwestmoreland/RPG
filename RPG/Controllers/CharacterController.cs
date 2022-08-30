using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RPG.Services;



namespace RPG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {

        private static ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        
        [HttpGet("GetAll")]

        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }


        
        [HttpGet("{id}")]

        public async Task<ActionResult<ServiceResponse<Character>>> GetSingal(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        
        
        [HttpPost]

        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddNewCharacter(newCharacter));
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<ServiceResponse<Character>>> CharacterUpdate(Character editCharacter)
        {
            return Ok(await _characterService.UpdateCharacter(editCharacter));
        }

    }

}

