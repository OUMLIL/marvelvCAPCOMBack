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
    public class AbilityService
    {
        public IList<AbilityDTO> getAbilities()
        {
            using (AbilityRepository _abilitiesRepo = new AbilityRepository())
            {
                return _abilitiesRepo.getAllAbilities();
            }
        }

        public AbilityDTO getAbilityByID(int id)
        {
            using (AbilityRepository _abilitiesRepo = new AbilityRepository())
            {
                return _abilitiesRepo.getAbilityByID(id);
            }
        }
        /*
        public AbilityDTO getAbilityByName(String name)
        {
            using (AbilityRepository _abilitiesRepo = new AbilityRepository())
            {
                return _abilitiesRepo.getAbilityByName(name);
            }
        }
        */

        public AbilityDTO addAbility(AbilityDTO abilityDto)
        {
            using (AbilityRepository _abilitiesRepo = new AbilityRepository())
            {
                return _abilitiesRepo.addAbility(abilityDto);
            }
        }

       public int deleteAbility(int id)
        {
            using (AbilityRepository _abilitiesRepo = new AbilityRepository())
            {
                return _abilitiesRepo.deleteAbility(id);
            }
        }

        public int updateAbility(AbilityDTO abilityDTO)
        {
            using (AbilityRepository _abilitiesRepo = new AbilityRepository())
            {
                return _abilitiesRepo.updateAbility(abilityDTO);
            }
        }
    }
}
