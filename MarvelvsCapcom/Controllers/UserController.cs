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
using MarvelvsCapcom.ViewModels;
using System.Web;


namespace MarvelvsCapcom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class UserController : ControllerBase
    {

        private readonly UserService _userservice = null;

        public UserController()
        {
            _userservice = new UserService();
        }

        [HttpGet("users")]
        public IActionResult getAll()
        {
            Console.WriteLine("GET CALL");
            return Ok(_userservice.getUsers());
        }
        
        [HttpGet("users/name")]
        public IActionResult getUserByName(string name)
        {   
            UserDTO usr = new UserDTO();
            try
            {
                usr = _userservice.getUserByName(name);
            } catch (Exception ex)
            {
                Console.WriteLine("sdkjqhkjdshjkfgdsjkhfgdsj");
                return BadRequest("");
            }
            return Ok(usr);
            
        }

        [HttpGet("users/byId/{id}")]
        public UserDTO getUserById(int id)
        {
            return _userservice.getUsersById(id);
        }

        [HttpGet("users/byUsername/{username}")]
        public IActionResult getUserByUsername(string username)
        {
            UserDTO user = new UserDTO();
            try
            {
                user = _userservice.getUsersByUsername(username);
            } catch (Exception ex)
            {
                return BadRequest("");
            }
            return Ok(user);
        }

        /*[HttpPost("users")]
        public int addUser(UserDTO user)
        {
            return _userservice.addUser(user);
        }*/

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

        [HttpPost("users")]
        public IList<UserDTO> manyadd(UserDTO[] usersDto)
        {
            return _userservice.manyadd(usersDto);
        }

        [HttpGet("users/user1/{name1}/user2/{name2}")]
        public IList<UserDTO> GetUsersGame(String name1, String name2)
        {
            String[] names = { name1, name2 };
            return _userservice.GetUsersGame(names);
        }

    }
}


//test