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
    public class UserLevelRepository : BaseRepository
    {
        public UserLevelRepository() : base() { }
        public UserLevelRepository(MRvsCPContext context) : base(context) { }

        public List<UserLevelDTO> getAllUserLevels()
        {
            List<UserLevel> userLevels = _dbcontext.UserLevels.ToList();
            return userLevels.Select(x => x.toDto()).ToList();
        } 
       
        public UserLevelDTO getUserLevelById(int id)
        {
            UserLevel userLevel = _dbcontext.UserLevels.SingleOrDefault(x => x.Id == id);  
            return userLevel.toDto();
        }

        public int addUserLevel(UserLevelDTO userLevelDto)
        {
            UserLevel userLevel = userLevelDto.toEntity(); 
            _dbcontext.UserLevels.Add(userLevel);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int deleteUserLevel(int id)
        {
            UserLevel userLevel = _dbcontext.UserLevels.SingleOrDefault(x => x.Id ==id);
            _dbcontext.UserLevels.Remove(userLevel);
            _dbcontext.SaveChanges();
            return 1;
        }

        public int updateUserLevel(UserLevelDTO userLevelDto)
        {
            UserLevel userLevel = userLevelDto.toEntity();
            _dbcontext.UserLevels.Update(userLevel);
            _dbcontext.SaveChanges();
            return 1;
        }

    }

    //id not incrementing, always 0 even after affecting a value
}
