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
    public class ArenaService
    {
        public IList<ArenaDTO> getArenas()
        {
            using (ArenaRepository _arenaRepository = new ArenaRepository())
            {
                return _arenaRepository.getAllArenas();
            }
        }

        public ArenaDTO getArenaById(int id)
        {
            using (ArenaRepository _arenaRepository = new ArenaRepository())
            {
                return _arenaRepository.getArenaById(id);
            }
        }

        public int addArena(ArenaDTO arenaDto)
        {
            using (ArenaRepository _arenaRepository = new ArenaRepository())
            {
                return _arenaRepository.addArena(arenaDto);
            }
        }

        public int deleteArena(int id)
        {
            using (ArenaRepository _arenaRepository = new ArenaRepository())
            {
                return _arenaRepository.deleteArena(id);
            }
        }

        public int updateArena(ArenaDTO arenaDto)
        {
            using (ArenaRepository _arenaRepository = new ArenaRepository())
            {
                return _arenaRepository.updateArena(arenaDto);
            }
        }
    }
}