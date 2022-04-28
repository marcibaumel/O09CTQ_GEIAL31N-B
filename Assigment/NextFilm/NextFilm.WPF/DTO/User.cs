using NextFilm.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.WPF.DTO
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public NextFilm.DataAccess.Models.User convertUserDtoToUser() {
            return new NextFilm.DataAccess.Models.User(this.Name, this.Email, this.Password);
        }

        public User convertUserToUserDto(NextFilm.DataAccess.Models.User user)
        {
            return new User(user.Name, user.Email, user.Password);
        }
    }

}
