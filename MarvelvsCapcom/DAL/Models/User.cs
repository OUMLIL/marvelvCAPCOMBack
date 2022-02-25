using System;
using System.Collections.Generic;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class User
    {
        public User()
        {
            RoundFirstPs = new HashSet<Round>();
            RoundSecondPs = new HashSet<Round>();
            RoundWinnerNavigations = new HashSet<Round>();
            UserLevels = new HashSet<UserLevel>();
        }

        public string? Username { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Round> RoundFirstPs { get; set; }
        public virtual ICollection<Round> RoundSecondPs { get; set; }
        public virtual ICollection<Round> RoundWinnerNavigations { get; set; }
        public virtual ICollection<UserLevel> UserLevels { get; set; }
    }
}
