using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.DAL.Extensions;

namespace MarvelvsCapcom.DAL.Repositories
{
    public class RoundRepository : BaseRepository
    {
        public RoundRepository() : base() { }
        public RoundRepository(MRvsCPContext context) : base(context) { }

        public List<RoundDTO> getAllRounds()
        {
            List<Round> rounds = _dbcontext.Rounds.ToList();
            return rounds.Select(x => x.toDto()).ToList();
        }

        public RoundDTO getRound(int id)
        {
            Round round = _dbcontext.Rounds.SingleOrDefault(x => x.Id == id);
            return round.toDto();
        }

        public int addRound(RoundDTO roundDto)
        {
            Round round = roundDto.toEntity();
            _dbcontext.Rounds.Add(round);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int updateRound(RoundDTO roundDto)
        {
            Round round = roundDto.toEntity();
            _dbcontext.Rounds.Update(round);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int deleteRound(int id)
        {
            Round round = _dbcontext.Rounds.SingleOrDefault(x => x.Id == id);
            _dbcontext.Rounds.Remove(round);
            _dbcontext.SaveChanges();
            return 1;
        }

    }
}
