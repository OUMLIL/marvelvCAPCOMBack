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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


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

        [HttpPost("games")]
        public IActionResult createGame(GameViewModel game)
        {
            /*GameViewModel game = new GameViewModel();
            game.User1 = user1;
            game.User2 = user2;
            game.p1_characs = p1_characters;
            game.p2_characs = p2_characters;*/
            
            string output = JsonConvert.SerializeObject(game);
            Console.WriteLine(output);

            return Ok(output);
        }
    }
}
