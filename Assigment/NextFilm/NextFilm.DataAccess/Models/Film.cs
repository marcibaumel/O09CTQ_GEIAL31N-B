using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.DataAccess.Models
{
    public class Film:BaseModel
    {
        public string Title { get; set; }
        public string Poster { get; set; }
        public bool IsWatched { get; set; }
        public DateTime ReleaseYear { get; set; }
        public DateTimeOffset AddedDate { get; set; }
        public User User { get; set; }

        public Film(string title, string poster, bool isWatched, DateTime releaseYear, DateTimeOffset addedDate, int userId)
        {
            Title = title;
            Poster = poster;
            IsWatched = isWatched;
            ReleaseYear = releaseYear;
            AddedDate = addedDate;
            User = null;
        }


    }

}
