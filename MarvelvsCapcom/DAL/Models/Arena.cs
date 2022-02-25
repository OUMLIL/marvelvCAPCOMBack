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

        public string Name { get; set; } = null!;
        public string? ArenaImg { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }
    }
}
