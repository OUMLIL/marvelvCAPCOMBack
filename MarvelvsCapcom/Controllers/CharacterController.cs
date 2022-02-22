using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.DAL.Extensions;
using MarvelvsCapcom.DAL.Repositories;
using MarvelvsCapcom.BL.Services;
//using MarvelvsCapcom.Exceptions;

namespace MarvelvsCapcom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly CharacterService _characterservice = null;

        public CharacterController()
        {
            _characterservice = new CharacterService();
        }

        [HttpGet("characters")]
        public IList<CharacterDTO> getAll()
        {
            return _characterservice.getCharacters();
        }

        [HttpGet("characters/{id}")]
        public CharacterDTO getCharacterByID(int id)
        {
            return _characterservice.getCharacterByID(id);
        }
        /*
        [HttpGet("characters/byName/{name}")]
        public CharacterDTO getCharacteryByName(String name)
        {
            return _characterservice.getCharacterByName(name);
        }
        */

        [HttpPost("characters")]
        /*public AbilityDTO AbilityDTO([FromBody] String name, [FromBody] int CoolDown, [FromBody] int damage)
        {
            return _abilityservice.addAbility(new AbilityDTO())
        }*/

        public IActionResult addCharacter(CharacterDTO characterDto)
        {
           // try
            //{
                _characterservice.addCharacter(characterDto);
                return Ok();
            //}
            /*catch (DatabaseException e)
            {
               // return BadRequest("The request created an error from the database");
            }*/

        }

        [HttpPut("characters")]
        public int updateCharacter(CharacterDTO characterDto)
        {
            return _characterservice.updateCharacter(characterDto);
        }

        [HttpDelete("characters/{id}")]
        public int deleteCharacter(int id)
        {
            return _characterservice.deleteCharacter(id);
        }


    }
}

//test