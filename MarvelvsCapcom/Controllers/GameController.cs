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

namespace MarvelvsCapcom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {

        //[Route ("api/Game/register")]
        /*public IActionResult userRegister(UserViewModel user1, UserViewModel user2) 
        {
         
        }*/

        [HttpGet ("games")]
        public GameDTO createGame(GameDTO game)
        {
            Console.WriteLine(game.ToString());
            return game;
        }
    }
}
