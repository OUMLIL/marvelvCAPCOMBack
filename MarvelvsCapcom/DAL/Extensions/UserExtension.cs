using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;

namespace MarvelvsCapcom.DAL.Extensions
{
    public static class UserExtension
    {
        public static User toEntity(this UserDTO userDto)
        {
            return new User
            {
                Id = userDto.Id,
                Username = userDto.Username
            };
        }

        public static UserDTO toDto(this User user)
        {
            if(user == null) return null;
            return new UserDTO
            {
                Id = user.Id,
                Username = user.Username
            };
        }
        
        //public virtual ICollection<UserLevelDTO> UserLevels { get; set; }
    }
}
