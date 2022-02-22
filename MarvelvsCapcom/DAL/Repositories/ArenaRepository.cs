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
    public class ArenaRepository : BaseRepository
    {
        public ArenaRepository() : base() { }
        public ArenaRepository(MRvsCPContext dbContext) : base(dbContext) { }

        public List<ArenaDTO> getAllArenas()
        {
            List<Arena> arenas = _dbcontext.Arenas.ToList();
            return arenas.Select(x => x.toDto()).ToList();
        }

        public ArenaDTO getArenaById(int id)
        {
            Arena arena = _dbcontext.Arenas.SingleOrDefault(x => x.Id == id);
            return arena.toDto();
        }

        public int addArena(ArenaDTO arenaDto)
        {
            Arena arena = arenaDto.toEntity();
            _dbcontext.Arenas.Add(arena);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int deleteArena(int id)
        {
            Arena arena = _dbcontext.Arenas.SingleOrDefault(x => x.Id == id);
            _dbcontext.Arenas.Remove(arena);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int updateArena(ArenaDTO arenaDto)
        {
            Arena arena = arenaDto.toEntity();
            _dbcontext.Arenas.Update(arena);
            _dbcontext.SaveChanges();
            return 1;
        }


        //public virtual ICollection<Round> Rounds { get; set; }
    }
}