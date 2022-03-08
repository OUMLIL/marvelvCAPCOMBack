using MarvelvsCapcom.ViewModels;
using MarvelvsCapcom.DTO.ModelsDTO;

namespace MarvelvsCapcom.ViewModels
{
    public class RoundViewModel
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


//------> name1/id/ability/id/attaque/name2/id
