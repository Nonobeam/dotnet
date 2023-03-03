using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;



namespace dotnet.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterControllers : ControllerBase{

        private readonly ICharacterService _characterService;
        public CharacterControllers(ICharacterService characterService){
            _characterService = characterService;
        }
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1, Name = "Mie"},
            new Character{Id = 2, Name = "Phuc"}
        };

        // private static List<Character> characters2 = new List<Character>{
        //     new Character(),
        //     new Character{Id = 2, Name = "Phuc"}
        // };

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get(){
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id){
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter){
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}