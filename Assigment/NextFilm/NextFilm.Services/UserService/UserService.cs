using NextFilm.DataAccess;
using NextFilm.DataAccess.Models;
using NextFilm.Services.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly GenericDataService<User> _genericData;

        public UserService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _genericData = new GenericDataService<User>(unitOfWork);
        }

        public bool Create(User entity)
        {
            return _genericData.Create(entity);
        }

        public bool Delete(int id)
        {
            return _genericData.Delete(id);
        }

        public User Get(int id)
        {
            return _genericData.Get(id);
        }

        public List<User> GetAll()
        {
            return _genericData.GetAll();
        }

        public bool Update(int id, User entity)
        {
            return _genericData.Update(id, entity);
        }

        public User GetUserByEmail(string email)
        {
            User entity = _unitOfWork.Users.FirstOrDefault(m => m.Email.Equals(email));
            return entity;
        }

        public User GetUserByName(string name)
        {
            User entity = _unitOfWork.Users.FirstOrDefault(m => m.Name.Equals(name));
            return entity;
        }
    }
}
