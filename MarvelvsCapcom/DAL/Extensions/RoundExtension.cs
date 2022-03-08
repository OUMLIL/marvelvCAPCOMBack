using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.ViewModels;

namespace MarvelvsCapcom.DAL.Extensions
{
    public static class RoundExtension
    {
        public static Round toEntity(this RoundDTO roundDto)
        {
            return new Round
            {
                Id = roundDto.Id,
                FirstPid = roundDto.FirstPid,
                SecondPid = roundDto.SecondPid,
                P1char1 = roundDto.P1char1,
                P1char2 = roundDto.P1char2,
                P1char3 = roundDto.P1char3,
                P2char1 = roundDto.P2char1,
                P2char2 = roundDto.P2char2,
                P2char3 = roundDto.P2char3,
                Winner  = roundDto.Winner,
                Arena = roundDto.Arena
            };
        }

        public static RoundDTO toDto(this Round round)
        {
            if (round == null)  return null;
            return new RoundDTO
            {
                Id = round.Id,
                FirstPid = round.FirstPid,
                SecondPid = round.SecondPid,
                P1char1 = round.P1char1,
                P1char2 = round.P1char2,
                P1char3 = round.P1char3,
                P2char1 = round.P2char1,
                P2char2 = round.P2char2,
                P2char3 = round.P2char3,
                Winner = round.Winner,
                Arena = round.Arena
            };
        }


        /*public static RoundViewModel dtoToViewModel(this Round round, UserViewModel winner)
        {
            return new RoundViewModel
            {
                Id = round.Id,
                FirstPid = round.FirstPid,
                SecondPid = round.SecondPid,
                P1char1 = round.P1char1,
                P1char2 = round.P1char2,
                P1char3 = round.P1char3,
                P2char1 = round.P2char1,
                P2char2 = round.P2char2,
                P2char3 = round.P2char3,
                Winner = winner,
                Arena = round.Arena
            }
        }*/


        /*public virtual ArenaDTO ArenaNavigation { get; set; } = null!;
        public virtual CharacterDTO? P1char1Navigation { get; set; }
        public virtual CharacterDTO? P1char2Navigation { get; set; }
        public virtual CharacterDTO? P1char3Navigation { get; set; }
        public virtual CharacterDTO? P2char1Navigation { get; set; }
        public virtual CharacterDTO? P2char2Navigation { get; set; }
        public virtual CharacterDTO? P2char3Navigation { get; set; }*/
    }
}
