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
    public class AbilityRepository : BaseRepository
    {
        public AbilityRepository(): base() { }
        public AbilityRepository(MRvsCPContext dbContext): base(dbContext) { }  

        public List<AbilityDTO> getAllAbilities()
        {
            List<Ability> abilities = _dbcontext.Abilities.ToList();
            return abilities.Select(x => x.toDto()).ToList();
        }

        public AbilityDTO getAbilityByID(int id)
        {
            Ability ability = _dbcontext.Abilities.SingleOrDefault(x => x.Id == id);
            return ability.toDto();

        }
        /*
        public AbilityDTO getAbilityByName(String name)
        {
            Ability ability = _dbcontext.Abilities.SingleOrDefault(x => x.AbName == name);
            return ability.toDto();
        }
        */
        public int addAbility(AbilityDTO abilityDto)
        {
            Ability ability = abilityDto.toEntity();
            _dbcontext.Abilities.Add(ability);
            _dbcontext.SaveChanges();

            return 1; //exceptions to add

        }


        public int deleteAbility(int id)
        {
            Ability ability = _dbcontext.Abilities.SingleOrDefault(x => x.Id == id);
            _dbcontext.Abilities.Remove(ability);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int updateAbility(AbilityDTO abilityDTO)
        {
            Ability ability = abilityDTO.toEntity();
            _dbcontext.Abilities.Update(ability);
            _dbcontext.SaveChanges() ;
            return 1;
        }
    }
}
