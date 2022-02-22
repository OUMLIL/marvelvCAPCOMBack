using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelvsCapcom.DTO.ModelsDTO;
using MarvelvsCapcom.DAL.Models;
using MarvelvsCapcom.DAL.Extensions;

namespace MarvelvsCapcom.DAL.Repositories
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly MRvsCPContext _dbcontext = null;

        public BaseRepository()
        {
            _dbcontext = new MRvsCPContext();
        }

        public BaseRepository(MRvsCPContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }

      
    }
}
