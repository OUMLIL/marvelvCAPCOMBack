using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;

namespace MarvelvsCapcom.DAL.Extensions
{
    public static class ArenaExtension
    {
        public static Arena toEntity(this ArenaDTO arenaDto)
        {
            return new Arena
            {
                Id = arenaDto.Id,
                Name = arenaDto.Name,
                ArenaImg = arenaDto.ArenaImg
            };
        }
        public static ArenaDTO toDto(this Arena arena)
        {
            if (arena == null) return null;
            return new ArenaDTO
            {
                Id = arena.Id,
                Name = arena.Name,
                ArenaImg = arena.ArenaImg
            };
        }

   
        //public virtual ICollection<Round> Rounds { get; set; }
    }
}
