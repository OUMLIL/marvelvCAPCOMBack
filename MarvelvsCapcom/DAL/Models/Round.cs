using System;
using System.Collections.Generic;

namespace MarvelvsCapcom.DAL.Models
{
    public partial class Round
    {
        public int Id { get; set; }
        public int FirstPid { get; set; }
        public int SecondPid { get; set; }
        public int? P1char1 { get; set; }
        public int? P1char2 { get; set; }
        public int? P1char3 { get; set; }
        public int? P2char1 { get; set; }
        public int? P2char2 { get; set; }
        public int? P2char3 { get; set; }
        public int? Winner { get; set; }
        public int Arena { get; set; }

        public virtual Arena ArenaNavigation { get; set; } = null!;
        public virtual User FirstP { get; set; } = null!;
        public virtual Character? P1char1Navigation { get; set; }
        public virtual Character? P1char2Navigation { get; set; }
        public virtual Character? P1char3Navigation { get; set; }
        public virtual Character? P2char1Navigation { get; set; }
        public virtual Character? P2char2Navigation { get; set; }
        public virtual Character? P2char3Navigation { get; set; }
        public virtual User SecondP { get; set; } = null!;
    }
}
