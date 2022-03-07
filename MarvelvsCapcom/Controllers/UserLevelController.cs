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
    public class UserLevelController : ControllerBase
    {
        private readonly UserLevelService _userLevelService = null;

        public UserLevelController()
        {
            _userLevelService = new UserLevelService();
        }

        [HttpGet("userLevels")]
        public IList<UserLevelDTO> getAllUserLevels()
        {
            return _userLevelService.getUserLevels();
        }

        [HttpGet("userLevels/{id}")]
        public UserLevelDTO getUserLevelById(int id)
        {
            return _userLevelService.getUserLevelById(id);
        }

        [HttpPost("userLevels")]
        public UserLevelDTO addUserLevel(UserLevelDTO userLevelDto)
        {
            return _userLevelService.addUserLevel(userLevelDto);
        }

        [HttpDelete("userLevels/{id}")]
        public int deleteUserLevel(int id)
        {
            return _userLevelService.deleteUserLevel(id);
        }

        [HttpPut("userLevels/{id}")]
        public int updateUserLevel(UserLevelDTO userLevelDto)
        {
            return _userLevelService.updateUserLevel(userLevelDto);
        }

    }
}
