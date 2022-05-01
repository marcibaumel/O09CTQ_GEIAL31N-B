using NextFilm.DataAccess;
using NextFilm.DataAccess.Models;
using NextFilm.Services.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.FilmService
{
    public class FilmService : IFilmService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GenericDataService<Film> _genericData;

        public FilmService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _genericData = new GenericDataService<Film>(unitOfWork);
        }

        public bool Create(Film entity)
        {
            return _genericData.Create(entity);
        }

        public bool Delete(int id)
        {
            return _genericData.Delete(id);
        }

        public Film Get(int id)
        {
            return _genericData.Get(id);
        }

        public List<Film> GetAll()
        {
            return _genericData.GetAll();
        }

        public bool Update(int id, Film entity)
        {
            return _genericData.Update(id, entity);
        }

        public List<Film> GetAllFilmsByUser(User user)
        {
            List<Film> entities = _unitOfWork.Films.Where(m => m.User.Equals(user) && !m.IsWatched).ToList();
            return entities;
        }

        public List<Film> GetAllFilmsByUserIsWatched(User user)
        {
            List<Film> entities = _unitOfWork.Films.Where(m => m.User.Equals(user) && m.IsWatched).ToList();
            return entities;
        }
    }
}
