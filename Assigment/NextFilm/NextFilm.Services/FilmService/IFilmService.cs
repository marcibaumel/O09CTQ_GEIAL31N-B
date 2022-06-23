using NextFilm.DataAccess.Models;
using NextFilm.Services.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.FilmService
{
    public interface IFilmService: IDataService<Film>
    {
        List<Film> GetAllFilmsByUser(User user);
        List<Film> GetAllFilmsByUserIsWatched(User user);
    }
}
