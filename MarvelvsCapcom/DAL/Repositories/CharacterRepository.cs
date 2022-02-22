using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.DAL.Extensions;
//using MarvelvsCapcom.Exceptions;

namespace MarvelvsCapcom.DAL.Repositories
{
    public class CharacterRepository : BaseRepository
    {
        public CharacterRepository() : base() { }
        public CharacterRepository(MRvsCPContext dbContext) : base(dbContext) { }

        public List<CharacterDTO> getAllCharacters()
        {
            List<Character> characters = _dbcontext.Characters.ToList();
            return characters.Select(x => x.toDto()).ToList();
        }

        public CharacterDTO getCharacterByID(int id)
        {
            Character character = _dbcontext.Characters.SingleOrDefault(x => x.Id == id);
            return character.toDto();

        }

        /*
        public CharacterDTO getCharacterByName(String name)
        {
            Character character = _dbcontext.Characters.SingleOrDefault(x => x.CharName == name);
            return character.toDto();
        }
        */

        public int addCharacter(CharacterDTO characterDto)
        {
            Character character = characterDto.toEntity();
            _dbcontext.Characters.Add(character);
            _dbcontext.SaveChanges();
            return 1; //exceptions to add

        }

        public int updateCharacter(CharacterDTO characterDto)
        {
            Character character = characterDto.toEntity();
            _dbcontext.Characters.Update(character);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int deleteCharacter(int id)
        {
            Character character = _dbcontext.Characters.SingleOrDefault(x => x.Id == id);
            _dbcontext.Characters.Remove(character);
            _dbcontext.SaveChanges();
            return 1;
        }
    }
}

//health points always null!!