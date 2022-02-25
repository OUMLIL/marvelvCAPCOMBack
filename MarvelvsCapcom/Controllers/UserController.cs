using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
using System.Web;


namespace MarvelvsCapcom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {

        private readonly UserService _userservice = null;

        public UserController()
        {
            _userservice = new UserService();
        }

        [HttpGet("users")]
        public IList<UserDTO> getAll()
        {
            return _userservice.getUsers();
        }

        [HttpGet("users/{id}")]
        public UserDTO getUserById(int id)
        {
            return _userservice.getUsersById(id);
        }

        [HttpPost("users/add")]
        public void addUser(UserDTO user)
        {
            _userservice.addUser(user);
        }

        [HttpPut("users")]
        public void updateUser(UserDTO user)
        {
            _userservice.updateUser(user);
        }

        [HttpDelete("users/{id}")]
        public void deleteUser(int id)
        {
            _userservice.deleteUser(id);
        }

    }
}


//test