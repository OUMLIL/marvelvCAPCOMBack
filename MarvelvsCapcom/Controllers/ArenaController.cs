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
    public class ArenaController : ControllerBase
    {
        private readonly ArenaService _arenaService = null;

        public ArenaController()
        {
            _arenaService = new ArenaService();
        }

        [HttpGet("arenas")]
        public IList<ArenaDTO> getArenas()
        {
            return _arenaService.getArenas();
        }

        [HttpGet("arenas/{id}")]
        public ArenaDTO getArenaById(int id)
        {
            return _arenaService.getArenaById(id);
        }

        [HttpPost("arenas")]
        public ArenaDTO addArena(ArenaDTO arenaDto)
        {
            return _arenaService.addArena(arenaDto);
        }

        [HttpDelete("arenas/{id}")]
        public int deleteArena(int id)
        {
            return _arenaService.deleteArena(id);
        }

        [HttpPut("arenas")]
        public int updateArena(ArenaDTO arenaDto)
        {
            return _arenaService.updateArena(arenaDto);
        }
    }
}