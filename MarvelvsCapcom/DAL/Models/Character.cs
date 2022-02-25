using System;
using System.Collections.Generic;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class Character
    {
        public Character()
        {
            RoundP1char1Navigations = new HashSet<Round>();
            RoundP1char2Navigations = new HashSet<Round>();
            RoundP1char3Navigations = new HashSet<Round>();
            RoundP2char1Navigations = new HashSet<Round>();
            RoundP2char2Navigations = new HashSet<Round>();
            RoundP2char3Navigations = new HashSet<Round>();
        }

        public string CharName { get; set; } = null!;
        public string? Side { get; set; }
        public int Ab1Id { get; set; }
        public int Ab2Id { get; set; }
        public int Ab3Id { get; set; }
        public int Ab4Id { get; set; }
        public int? HeathPoints { get; set; }
        public int Id { get; set; }

        public virtual Ability Ab1 { get; set; } = null!;
        public virtual Ability Ab2 { get; set; } = null!;
        public virtual Ability Ab3 { get; set; } = null!;
        public virtual Ability Ab4 { get; set; } = null!;
        public virtual ICollection<Round> RoundP1char1Navigations { get; set; }
        public virtual ICollection<Round> RoundP1char2Navigations { get; set; }
        public virtual ICollection<Round> RoundP1char3Navigations { get; set; }
        public virtual ICollection<Round> RoundP2char1Navigations { get; set; }
        public virtual ICollection<Round> RoundP2char2Navigations { get; set; }
        public virtual ICollection<Round> RoundP2char3Navigations { get; set; }
    }
}
