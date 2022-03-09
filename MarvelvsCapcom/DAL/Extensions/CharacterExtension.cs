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
    public static class CharacterExtension
    {
        public static Character toEntity(this CharacterDTO characterDto)
        {
            return new Character
            {
                Id = characterDto.Id,
                CharName = characterDto.CharName,
                Side = characterDto.Side,
                Ab1Id = characterDto.Ab1Id,
                Ab2Id = characterDto.Ab2Id,
                Ab3Id = characterDto.Ab3Id,
                Ab4Id = characterDto.Ab4Id,
                HeathPoints = characterDto.HeathPoints
            };
        }

        public static CharacterDTO toDto(this Character character)
        {
            if (character == null) return null;
            return new CharacterDTO
            {
                Id = character.Id,
                CharName = character.CharName,
                Side = character.Side,
                Ab1Id = character.Ab1Id,
                Ab2Id = character.Ab2Id,
                Ab3Id = character.Ab3Id,
                Ab4Id = character.Ab4Id,
                HeathPoints = character.HeathPoints
            };
        }

        public static CharactersDetailDTO toDto(CharacterViewModel character) 
        {
            return new CharactersDetailDTO
            {
                Id = character.Id,
                CharName = character.CharName,
                Side = character.Side,
                Ab1 = character.Ab1,
                Ab2 = character.Ab2,
                Ab3 = character.Ab3,
                Ab4 = character.Ab4,

                Ab1Id = character.Ab1Id,
                Ab2Id = character.Ab2Id,
                Ab3Id = character.Ab3Id,
                Ab4Id = character.Ab4Id,

                HeathPoints = character.HeathPoints
            };

        }

        /*public int Id { get; set; }
        public string CharName { get; set; } = null!;
        public string? Side { get; set; }
        public AbilityDTO Ab1 { get; set; }
        public AbilityDTO Ab2 { get; set; }
        public AbilityDTO Ab3 { get; set; }
        public AbilityDTO Ab4 { get; set; }

        public int Ab1Id { get; set; }
        public int Ab2Id { get; set; }
        public int Ab3Id { get; set; }
        public int Ab4Id { get; set; }
        public int? HeathPoints { get; set; }*/


        /* public virtual Ability Ab1 { get; set; } = null!;
         public virtual Ability Ab2 { get; set; } = null!;
         public virtual Ability Ab3 { get; set; } = null!;
         public virtual Ability Ab4 { get; set; } = null!;
         public virtual ICollection<RoundDTO> RoundP1char1Navigations { get; set; }
         public virtual ICollection<RoundDTO> RoundP1char2Navigations { get; set; }
         public virtual ICollection<RoundDTO> RoundP1char3Navigations { get; set; }
         public virtual ICollection<RoundDTO> RoundP2char1Navigations { get; set; }
         public virtual ICollection<RoundDTO> RoundP2char2Navigations { get; set; }
         public virtual ICollection<RoundDTO> RoundP2char3Navigations { get; set; }
        */
    }
}
