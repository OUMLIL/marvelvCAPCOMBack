using System;
using System.Collections.Generic;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class Ability
    {
        public Ability()
        {
            CharacterAb1s = new HashSet<Character>();
            CharacterAb2s = new HashSet<Character>();
            CharacterAb3s = new HashSet<Character>();
            CharacterAb4s = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string AbName { get; set; } = null!;
        public int CoolDown { get; set; }
        public int Damage { get; set; }

        public virtual ICollection<Character> CharacterAb1s { get; set; }
        public virtual ICollection<Character> CharacterAb2s { get; set; }
        public virtual ICollection<Character> CharacterAb3s { get; set; }
        public virtual ICollection<Character> CharacterAb4s { get; set; }
    }
}
