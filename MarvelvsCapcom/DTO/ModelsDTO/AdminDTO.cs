using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public partial class AdminDTO
    {
        public string? Passwd { get; set; }
        public int Id { get; set; }


        //Add pw hashing method
        //Add authentication method
        //Add token generation for session
        //Only admins can add elements to db ?? (adding characters/maps/abilities ??)
    }
}
