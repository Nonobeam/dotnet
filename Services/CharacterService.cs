using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Services.CharacterService{

    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            ServiceResponse.Data = characters;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return new ServiceReponse<List<Character>> { Data = characters };
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var ServiceReponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => char.Id == id);
            ServiceReponse.Data = character;
            return ServiceReponse;
        }
    }
}