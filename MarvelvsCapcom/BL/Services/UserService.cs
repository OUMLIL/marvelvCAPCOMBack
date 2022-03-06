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
    public class UserService
    {
        public IList<UserDTO> getUsers()
        {
            using (UserRepository _usersRepo = new UserRepository())
            {
                return _usersRepo.getAllUsers();
            }
        }

        public UserDTO getUsersById(int id)
        {
            using (UserRepository _usersRepo = new UserRepository())
            {
                return _usersRepo.getUserById(id);
            }
        }

        public UserDTO getUsersByUsername(string username)
        {
            using(UserRepository _usersRepo = new UserRepository())
            {
                try
                {
                    return _usersRepo.getUserByName(username);
                } catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public int addUser(UserDTO user)
        {
            using (UserRepository _usersRepo = new UserRepository())
            {
                return _usersRepo.AddUser(user);
            }
        }

        public IList<UserDTO> manyadd(UserDTO[] usersDto)
        {
            using (UserRepository _usersRepo = new UserRepository())
            {
                return _usersRepo.manyadd(usersDto);
            }
        }


        public IList<UserDTO> GetUsersGame(String[] names)
        {
            using(UserRepository _usersRepo = new UserRepository())
            {
                return _usersRepo.GetUsersGame(names);
            }
        }

        public void updateUser(UserDTO user)
        {
            using (UserRepository _usersRepo = new UserRepository())
            {
                _usersRepo.updateUser(user);
            }
        }

        public void deleteUser(int id)
        {
            using (UserRepository _userRepo = new UserRepository())
            {
                _userRepo.deleteUser(id);
            }
        }
    }
}

//Test