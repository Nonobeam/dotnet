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
        public ActionResult<List<Character>> Get(){
            return Ok(_characterService.GetAllCharacters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}