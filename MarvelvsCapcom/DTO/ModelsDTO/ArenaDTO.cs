using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelvsCapcom.DTO.ModelsDTO
{
    public partial class ArenaDTO
    {
        public ArenaDTO()
        {
  
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ArenaImg { get; set; }

    }
}
