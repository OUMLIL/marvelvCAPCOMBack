using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace MarvelvsCapcom.DAL.Repositories
{
    public class AdminRepository : BaseRepository
    {
        public AdminRepository() : base() { }
        public AdminRepository(MRvsCPContext dbContext) : base(dbContext) { }

        public IList<AdminDTO> getAllAdmins()
        {   
            try {
                List<Admin> admins = _dbcontext.Admins.ToList();
                return admins.Select(x => x.toDto()).ToList();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        public AdminDTO getAdminById(int id)
        {
            try
            {
                Admin admin = _dbcontext.Admins.SingleOrDefault(x => x.Id == id);
                return admin.toDto();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void addAdmin(AdminDTO adminDto)
        {

            try
            {
                Admin admin = adminDto.toEntity();
                _dbcontext.Admins.Add(admin);
                _dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public void deleteAdmin(int id)
        {   
            try
            {
                Admin admin = _dbcontext.Admins.SingleOrDefault(x => x.Id == id);
                _dbcontext.Admins.Remove(admin);
                _dbcontext.SaveChanges();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public void updateAdminPassword(AdminDTO adminDto)
        {
            try
            {
                Admin admin = adminDto.toEntity();
                _dbcontext.Admins.Update(admin);
                _dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}


//exceptions to add for all functions with int return type