using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public partial class AdminDTO
    {
        public string Passwd { get; set; }
        public int Id { get; set; }

        private byte[] passwordSalt;


        //Add authentication method
        //Add token generation for session
        //Only admins can add elements to db ?? (adding characters/maps/abilities ??)

        public void CreatePasswordHash(String password)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                Passwd = System.Text.Encoding.UTF8.GetString(passwordHash);
            }
        }

        public bool VerifyPasswordHash(string password)
        {
            
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                string hashedpw = System.Text.Encoding.UTF8.GetString(computedHash);
                return hashedpw.SequenceEqual(Passwd);
            }
        }
    }
}
