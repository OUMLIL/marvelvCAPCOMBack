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
    public class AdminController : ControllerBase

    {
        private readonly AdminService _adminService = null;

        public AdminController()
        {
            _adminService = new AdminService();
        }

        [HttpGet("admins")]
        public IList<AdminDTO> GetAdmins()
        {
            return _adminService.getAllAdmins();
        }

        /*[HttpPut("admins")]
        public IActionResult updatePassword(AdminDTO admindto)
        {
           
           _adminService.updateAdminPassword(admindto);
            return Ok();
        }*/

        /*[HttpPost("admins")]
        public void addAdmin(AdminDTO adminDto, string adminName)
        {
            _adminService.addAdmin(adminDto, adminName);
        }*/


        /*//[HttpGet("abilities/byID/{id}")]
        [HttpGet("abilities/{id}")]
        public AbilityDTO getAbilityByID(int id)
        {
            return _abilityservice.getAbilityByID(id);
        }

        *//*
        [HttpGet("abilities/byName/{name}")]
        public AbilityDTO getAbilityByName(String name)
        {
            return _abilityservice.getAbilityByName(name);
        }
        *//*

        [HttpPost("abilities")]
        *//*public AbilityDTO AbilityDTO([FromBody] String name, [FromBody] int CoolDown, [FromBody] int damage)
        {
            return _abilityservice.addAbility(new AbilityDTO())
        }*//*

        public void addAbility(AbilityDTO abilityDto)
        {
            _abilityservice.addAbility(abilityDto);

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
        }*/

    }
}
