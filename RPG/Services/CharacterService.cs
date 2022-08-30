using RPG.Models;
using RPG.Dtos.Character;


namespace RPG.Services
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> _characters = new()
        {
            new Character(),
            new Character {
                Id = 1,
                Name = "Picco the Tiny!",
                RpgClass = RpgClass.Mage,
            },
            new Character {
                Id = 2,
                Name = "Queen Logan the Lovely!!",
                Strength = 14,
                RpgClass = RpgClass.Healer,
            },
            new Character {
                Id = 3,
                Name = "Wes the Weasel King!!",
                HitPoints = 100,
                RpgClass = RpgClass.Hulk,
            },
            new Character {
                Id = 4,
                Name = "Squidny!",
                RpgClass = RpgClass.Kraken,
            }

        };

        public async Task<ServiceResponse<List<Character>>> AddNewCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            _characters.Add(newCharacter);
            serviceResponse.Data = _characters;
            return serviceResponse;
        }


        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return new ServiceResponse<List<Character>> { Data = _characters};
        }


        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = _characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> UpdateCharacter(Character editCharacter)
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            Character character = _characters.FirstOrDefault(c => c.Id == editCharacter.Id);

            character.Name = editCharacter.Name;
            character.HitPoints = editCharacter.HitPoints;
            character.Strength = editCharacter.Strength;
            character.Defense = editCharacter.Defense;
            character.Intelligence = editCharacter.Intelligence;
            character.RpgClass = editCharacter.RpgClass;

            serviceResponse.Data = character;

            return serviceResponse;
            
            
        }
    }
}
