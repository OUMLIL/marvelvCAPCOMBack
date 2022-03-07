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

namespace MarvelvsCapcom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbilityController : ControllerBase

    {
        private readonly AbilityService _abilityservice = null;

        public AbilityController()
        {
            _abilityservice = new AbilityService(); 
        }

        [HttpGet("abilities")]
        public IList<AbilityDTO> getAll()
        {
            return _abilityservice.getAbilities();
        }

        //[HttpGet("abilities/byID/{id}")]
        [HttpGet("abilities/{id}")]
        public AbilityDTO getAbilityByID(int id)
        {
            return _abilityservice.getAbilityByID(id);
        }

        /*
        [HttpGet("abilities/byName/{name}")]
        public AbilityDTO getAbilityByName(String name)
        {
            return _abilityservice.getAbilityByName(name);
        }
        */

        [HttpPost("abilities")]
        /*public AbilityDTO AbilityDTO([FromBody] String name, [FromBody] int CoolDown, [FromBody] int damage)
        {
            return _abilityservice.addAbility(new AbilityDTO())
        }*/

        public AbilityDTO addAbility(AbilityDTO abilityDto) 
        {
            return _abilityservice.addAbility(abilityDto);
            
        }

        //[HttpDelete("abilities/byID/{id}")]
        [HttpDelete("abilities/{id}")]
        public int deleteAbility(int id)
        {
            return _abilityservice.deleteAbility(id);
        }

        [HttpPut("abilities")]
        public int updateAbility(AbilityDTO abilityDTO)
        {
            return _abilityservice.updateAbility(abilityDTO);
        }
    }
}