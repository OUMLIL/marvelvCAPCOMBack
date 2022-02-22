using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;

namespace MarvelvsCapcom.DAL.Extensions
{
    public static class AbilityExtension
    {
        public static Ability toEntity(this AbilityDTO abilityDto)
        {
            return new Ability
            {
                Id = abilityDto.Id,
                AbName = abilityDto.AbName,
                CoolDown = abilityDto.CoolDown,
                Damage = abilityDto.Damage
            };
        }

        public static AbilityDTO toDto(this Ability abilities)
        {
            if (abilities == null) return null;

            return new AbilityDTO
            {
                Id = abilities.Id,
                AbName = abilities.AbName,
                CoolDown = abilities.CoolDown,
                Damage = abilities.Damage
            };
        }
        /*public virtual CharacterDTO CharacterAb1 { get; set; } = null!;
        public virtual CharacterDTO CharacterAb2 { get; set; } = null!;
        public virtual CharacterDTO CharacterAb3 { get; set; } = null!;
        public virtual CharacterDTO CharacterAb4 { get; set; } = null!;*/
    }
}
