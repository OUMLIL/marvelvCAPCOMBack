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
using MarvelvsCapcom.ViewModels;
//using MarvelvsCapcom.Exceptions;

namespace MarvelvsCapcom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly CharacterService _characterservice = null;
        private readonly AbilityService _abilityService = null;

        public CharacterController()
        {
            _characterservice = new CharacterService();
            _abilityService = new AbilityService();
        }

        [HttpGet("characters")]
        public IList<CharacterViewModel> getAll()
        {
            IList<CharacterDTO> characters = _characterservice.getCharacters();
            IList<CharacterViewModel> all = new List<CharacterViewModel>();
  
            foreach(CharacterDTO character in characters)
            {
                CharacterViewModel tmp = new CharacterViewModel();
                tmp.Id= character.Id;
                tmp.CharName= character.CharName;
                tmp.Ab1 = _abilityService.getAbilityByID(character.Ab1Id);
                tmp.Ab2 = _abilityService.getAbilityByID(character.Ab2Id);
                tmp.Ab3 = _abilityService.getAbilityByID(character.Ab3Id);
                tmp.Ab4 = _abilityService.getAbilityByID(character.Ab4Id);

                tmp.Ab1Id = character.Ab1Id;
                tmp.Ab2Id = character.Ab2Id;
                tmp.Ab3Id = character.Ab3Id;
                tmp.Ab4Id = character.Ab4Id;

                tmp.HeathPoints = character.HeathPoints;    

                all.Add(tmp);
            }

            return all;
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

        public CharacterDTO addCharacter(CharacterDTO characterDto)
        {
           // try
            //{
                return _characterservice.addCharacter(characterDto);
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