using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Dtos.Character;

namespace dotnet.Services.CharacterService{

    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            ServiceResponse.Data = characters;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            return new ServiceResponse<List<Character>> { Data = characters };
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceReponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceReponse.Data = character;
            return serviceReponse;
        }
    }
}