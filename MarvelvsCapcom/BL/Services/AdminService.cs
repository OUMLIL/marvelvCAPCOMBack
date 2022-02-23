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
        
        public void addAdmin(AdminDTO adminDto)
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                try
                {
                    _adminRepo.addAdmin(adminDto);
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                
            }
        }

        public void deleteAdmin(int id)
        {
            using (AdminRepository _adminRepo = new AdminRepository())
            {
                try
                {
                    _adminRepo.deleteAdmin(id);
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                
            }
        }

        
        public void updateAdminPassword(AdminDTO adminDto)
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
        }
    }
}
