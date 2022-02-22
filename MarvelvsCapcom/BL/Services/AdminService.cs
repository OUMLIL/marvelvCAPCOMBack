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
    public class AdminService
    {


        public IList<AdminDTO> getAllAdmins()
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                return _adminRepo.getAllAdmins();
            }
        }

        
        public AdminDTO getAdminById(int id)
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                return _adminRepo.getAdminById(id);
            }
        }

        public AdminDTO getAdminByName(string name)
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                return _adminRepo.getAdminByName(name);
            }
        }
        
        /*public int addAdmin(AdminDTO adminDto, string adminName)
        {
            int userId = 0;
            //first adding the admin as normal user
            using(UserRepository _userRepo = new UserRepository())
            {
                User user = new User
                {
                    Id = adminDto.Id,
                    Username = adminName
                };
                _userRepo.AddUser(user.toDto());
                List < UserDTO > users = _userRepo.getAllUsers();
                userId = users[users.Count - 1].Id;
            }

            //then adding the admin
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                return _adminRepo.addAdmin(adminDto, adminName, userId);
            }
        }
        public int deleteAdmin(int id)
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                return _adminRepo.deleteAdmin(id);
            }
        }*/
        /*public void updateAdminPassword(AdminDTO adminDto)
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                try
                {
                    _adminRepo.updateAdminPassword(adminDto);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }*/
    }
}
