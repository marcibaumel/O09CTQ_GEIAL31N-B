using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.DataAccess.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public bool IsWatched { get; set; }
        public DateTime ReleaseYear { get; set; }
        public DateTimeOffset AddedDate { get; set; }
        public User User { get; set; }
    }
}
