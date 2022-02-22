using System;
using System.Collections.Generic;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class Arena
    {
        public Arena()
        {
            Rounds = new HashSet<Round>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ArenaImg { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }
    }
}
