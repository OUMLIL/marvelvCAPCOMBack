using System;
using System.Collections.Generic;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class UserLevel
    {
        public int UserId { get; set; }
        public int CharacterId { get; set; }
        public int? Level { get; set; }
        public int Id { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
