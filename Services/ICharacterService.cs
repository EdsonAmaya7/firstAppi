using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace firstAppi.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>>GetAllCharacters();
        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
        Task<ServiceResponse<GetCharacterDTO>> GetFirstCharacter();
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
    }
}