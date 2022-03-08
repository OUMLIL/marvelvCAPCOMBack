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
    public class RoundController : ControllerBase
    {
        private readonly RoundService _roundService = null;
        public RoundController()
        {
            _roundService = new RoundService();
        }

        [HttpGet("rounds")]
        public IList<RoundDTO> getAll()
        {
            return _roundService.getRounds();
        }

        [HttpGet("rounds/{id}")]
        public RoundDTO getRoundById(int id)
        {
            return _roundService.getRoundById(id);
        }

        [HttpPost("rounds")]
        public RoundDTO addRound(RoundDTO round)
        {   
            return _roundService.addRound(round);
        }

        [HttpPut("rounds")]
        public int updateRound(RoundDTO roundDto)
        {
            return _roundService.updateRound(roundDto);
        }

        [HttpDelete("rounds/{id}")]
        public int deleteRound(int id)
        {
            return _roundService.deleteRound(id);
        }
    }
}
