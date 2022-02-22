using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;

namespace MarvelvsCapcom.DAL.Extensions
{
    public static class UserLevelExtension
    {
        public static UserLevel toEntity(this UserLevelDTO userLevelDto)
        {
            return new UserLevel
            {
                UserId = userLevelDto.UserId,
                CharacterId = userLevelDto.CharacterId,
                Level = userLevelDto.Level
            };
        }

        public static UserLevelDTO toDto(this UserLevel userLevel)
        {
            if(userLevel == null) return null;
            return new UserLevelDTO
            {
                UserId = userLevel.UserId,
                CharacterId = userLevel.CharacterId,
                Level = userLevel.Level
            };
        }
       

      //  public virtual UserDTO User { get; set; } = null!;
    }
}
