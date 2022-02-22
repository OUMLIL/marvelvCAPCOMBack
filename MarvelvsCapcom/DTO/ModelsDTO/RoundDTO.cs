using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public partial class RoundDTO
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
    }
}
