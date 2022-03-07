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
    public class UserRepository : BaseRepository
    {
        public UserRepository() : base() { }
        public UserRepository(MRvsCPContext context) : base(context) { }

        public List<UserDTO> getAllUsers()
        {
            List<User> users = _dbcontext.Users.ToList();
            return users.Select(x => x.toDto()).ToList();
        }

        public UserDTO getUserById(int id)
        {
            return _dbcontext.Users.SingleOrDefault(x => x.Id == id).toDto();
        }


        public UserDTO getUserByName(string username)
        {
            try
            {
                return _dbcontext.Users.Single(x => x.Username == username).toDto();
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }

        public int AddUser(UserDTO userDto)
        {
            User user = userDto.toEntity();
            user.Id = _dbcontext.Users.Count();
            _dbcontext.Users.Add(user);
            _dbcontext.SaveChanges();
            return user.Id;
        }

        public void deleteUser(int id)
        {
            User user = _dbcontext.Users.SingleOrDefault(x => x.Id == id);
            _dbcontext.Users.Remove(user);
            _dbcontext.SaveChanges(); 
        }

        public void updateUser(UserDTO userDto)
        {

            User user = userDto.toEntity();
            _dbcontext.Users.Update(user);
            _dbcontext.SaveChanges();

        }

        public IList<UserDTO> manyadd(UserDTO[] usersDto)
        {
            IList<UserDTO> users = new List<UserDTO>();
            foreach(UserDTO userDto in usersDto)
            {
                User user = userDto.toEntity();
                user.Id = _dbcontext.Users.Count();
                _dbcontext.Users.Add(user);
                _dbcontext.SaveChanges();
                users.Add(user.toDto());
            }
            return users;
        }

        public IList<UserDTO> GetUsersGame(String[] names)
        {
            List<UserDTO> users = new List<UserDTO>();
            foreach(String name in names)
            {
                users.Add(_dbcontext.Users.SingleOrDefault(x => x.Username == name).toDto());
            }
            return users;
        }

    }
}