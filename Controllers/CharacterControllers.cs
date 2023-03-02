using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace dotnet.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterControllers : ControllerBase{
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
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}