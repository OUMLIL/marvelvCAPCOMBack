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

        public void AddUser(UserDTO user)
        {
            _dbcontext.Users.Add(user.toEntity());
            _dbcontext.SaveChanges();
        }

        public void deleteUser(int id)
        {
            _dbcontext.Users.Remove(getUserById(id).toEntity());
            _dbcontext.SaveChanges();
        }

        public void updateUser(UserDTO userDto)
        {
            User user = userDto.toEntity();
            _dbcontext.Users.Update(user);
            _dbcontext.SaveChanges();

        }

    }
}