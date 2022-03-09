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
        public GameViewModel _game;
        /// <summary>  
        /// Injecting dependency of the Singleton class - CustomerFeatures  
        /// </summary>  
        /// <param name="customerFeatures"></param>  
        public GameController(GameViewModel game)
        {
            _game = game;
        }


        [HttpPost("games")]
        public GameViewModel createGame(GameViewModel gameVM)
        {
            _game.User1 = gameVM.User1;
            _game.User2 = gameVM.User2;
            _game.p1_characs = gameVM.p1_characs;
            _game.p2_characs = gameVM.p2_characs;
            
            string output = JsonConvert.SerializeObject(_game);
            //Console.WriteLine(output);
            Console.WriteLine(_game.ToString());
            return _game;
        }

        [HttpPost("games/attack/attackedPlayer/{pid}/attackedCharacter/{cid}/damage/{damage}")]
        public GameViewModel attack(int pid, int cid, int damage)
        {
            //Console.WriteLine(game.User1);
            if(_game.User1.Id == pid)
            {
                Console.WriteLine("hna");
                this._game.p1_characs.First(c => c.Id == cid).HeathPoints -= (int?) damage;
            }
            else
            {
                Console.WriteLine("lheh 7sn mn hna");
                this._game.p2_characs.First(c => c.Id == cid).HeathPoints -= (int?) damage;
            }
            return _game;
        }

    }
}
