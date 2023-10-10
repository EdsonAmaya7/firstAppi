
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstAppi.Services;
using Microsoft.AspNetCore.Mvc;

namespace firstAppi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _icharacterService;

        public CharacterController(ICharacterService Icharacter)
        {
            _icharacterService = Icharacter;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get(){
            return Ok(await _icharacterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingle(int id){
            return Ok(await _icharacterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> AddCharacter(AddCharacterDTO newCharacter){
            return Ok (await _icharacterService.AddCharacter(newCharacter));
        }
    }
}