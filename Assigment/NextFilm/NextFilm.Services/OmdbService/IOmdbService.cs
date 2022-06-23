using NextFilm.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.OmdbService
{
    public interface IOmdbService
    {
        public Task<Film> Load(string Title, string Year);
    }
}
