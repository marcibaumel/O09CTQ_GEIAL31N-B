using NextFilm.DataAccess.Models;
using NextFilm.Services.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.UserService
{
    public interface IUserService: IDataService<User>
    {
        User GetUserByName(string name);
        User GetUserByEmail(string email);
    }
}
