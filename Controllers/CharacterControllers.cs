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
            new Character{Name = "Sam"}
        };

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get(){
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle(){
            return Ok(characters[0]);
        }
    }
}