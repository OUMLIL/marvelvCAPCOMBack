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

        //to remove pour le rendu final
        [HttpGet("admins")]
        public IList<AdminDTO> GetAdmins()
        {
            return _adminService.getAllAdmins();
        }

        //to remove pour le rendu final
        [HttpPost("admins")]
        public void addAdmin(AdminDTO adminDto)
        {
            adminDto.CreatePasswordHash(adminDto.Passwd);
            _adminService.addAdmin(adminDto);
        }

        [HttpPost("admins/login")]
        public IActionResult loginAdmin(AdminDTO adminDto)
        {
            AdminDTO AdmServer;
            try
            {
                AdmServer = _adminService.getAdminById(adminDto.Id);
            }
            catch (Exception ex)
            {
                return BadRequest("Admin not found");
            }

            if (adminDto.Passwd != AdmServer.Passwd)
            {
                return BadRequest("Password incorrect");
            }

            return Ok("Access Granted");
        }

    }
}
