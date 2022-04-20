using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public List<FilmModel> Film { get; set; }

        public UserModel(Guid userId, string name, string email, string password, DateTimeOffset createdDate, List<FilmModel> film)
        {
            UserId = userId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            CreatedDate = createdDate;
            Film = film;
        }
    }
}
