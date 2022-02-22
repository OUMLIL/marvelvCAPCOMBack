using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public partial class AbilityDTO
    {
        public int Id { get; set; }
        public string AbName { get; set; } = null!;
        public int CoolDown { get; set; }
        public int Damage { get; set; }

    }
}
