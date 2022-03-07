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
    public class UserLevelService
    {
        public IList<UserLevelDTO> getUserLevels()
        {
            using (UserLevelRepository _userLevelRepository = new UserLevelRepository())
            {
                return _userLevelRepository.getAllUserLevels();
            }
        }

        public UserLevelDTO getUserLevelById(int id)
        {
            using(UserLevelRepository _userLevelRepository = new UserLevelRepository())
            {
                return _userLevelRepository.getUserLevelById(id);
            }
        }

        public UserLevelDTO addUserLevel(UserLevelDTO userLevelDto)
        {
            using (UserLevelRepository _userLevelRepository = new UserLevelRepository())
            {
                return _userLevelRepository.addUserLevel(userLevelDto);
            }
        }

        public int deleteUserLevel(int id)
        {
            using (UserLevelRepository _userLevelRepository = new UserLevelRepository())
            {
                return _userLevelRepository.deleteUserLevel(id);
            }
        }

        public int updateUserLevel(UserLevelDTO userLevelDto)
        {
            using (UserLevelRepository _userLevelRepository = new UserLevelRepository())
            {
                return _userLevelRepository.updateUserLevel(userLevelDto);
            }
        }

    }
}
