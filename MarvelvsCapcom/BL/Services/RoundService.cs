using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.DAL.Extensions;
using MarvelvsCapcom.DAL.Repositories;
namespace MarvelvsCapcom.BL.Services
{
    public class RoundService
    {
        public IList<RoundDTO> getRounds()
        {
            using (RoundRepository _roundsRepo = new RoundRepository())
            {
                return _roundsRepo.getAllRounds();
            }
        }

        public RoundDTO getRoundById(int id)
        {
            using (RoundRepository _roundsRepo = new RoundRepository())
            {
                return _roundsRepo.getRound(id);
            }
        }

        public RoundDTO addRound(RoundDTO roundDto)
        {
            using (RoundRepository _roundsRepo = new RoundRepository())
            {
                return _roundsRepo.addRound(roundDto);
            }
        }

        public int updateRound(RoundDTO roundDto)
        {
            using (RoundRepository _roundsRepo = new RoundRepository())
            {
                return _roundsRepo.updateRound(roundDto);
            }
        }

        public int deleteRound(int id)
        {
            using (RoundRepository _roundsRepo = new RoundRepository())
            {
                return _roundsRepo.deleteRound(id);
            }
        }
    }
}
