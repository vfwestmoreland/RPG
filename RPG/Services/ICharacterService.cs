namespace RPG.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();

        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddNewCharacter(Character newCharacter);

        Task<ServiceResponse<Character>> UpdateCharacter(Character editCharacter);

    }
}
