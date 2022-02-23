using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;

namespace MarvelvsCapcom.DAL.Extensions
{
    public static class AdminExtension
    {
        public static Admin toEntity(this AdminDTO adminDto)
        {
            return new Admin
            {
                Id = adminDto.Id,
                Passwd = adminDto.Passwd
            };
        }

        public static AdminDTO toDto(this Admin admin)
        {
            if (admin == null) return null;
            return new AdminDTO
            {
                Id = admin.Id,
                Passwd = admin.Passwd,
            };
        }

        // public virtual UserDTO IdNavigation { get; set; } = null!;
    }
}

