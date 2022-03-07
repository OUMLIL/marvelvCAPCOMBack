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
    public class CharacterService
    {
        public IList<CharacterDTO> getCharacters()
        {
            using (CharacterRepository _charactersRepo = new CharacterRepository())
            {
                return _charactersRepo.getAllCharacters();
            }
        }

        public CharacterDTO getCharacterByID(int id)
        {
            using (CharacterRepository _charactersRepo = new CharacterRepository())
            {
                return _charactersRepo.getCharacterByID(id);
            }
        }
        /*
        public CharacterDTO getCharacterByName(String name)
        {
            using (CharacterRepository _charactersRepo = new CharacterRepository())
            {
                return _charactersRepo.getCharacterByName(name);
            }
        }*/

        public CharacterDTO addCharacter(CharacterDTO characterDto)
        {
            using (CharacterRepository _charactersRepo = new CharacterRepository())
            {
                return _charactersRepo.addCharacter(characterDto);
            }
        }

        public int updateCharacter(CharacterDTO characterDto)
        {
            using(CharacterRepository _charactersRepo = new CharacterRepository())
            {
                return _charactersRepo.updateCharacter(characterDto);
            }
        }

        public int deleteCharacter(int id)
        {
            using(CharacterRepository _charactersRepo = new CharacterRepository())
            {
                return _charactersRepo.deleteCharacter(id);
            }
        }
    }
}

//Test