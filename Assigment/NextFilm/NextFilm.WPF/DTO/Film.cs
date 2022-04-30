using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.WPF.DTO
{
    public class Film
    {
        private Task<DataAccess.Models.Film> task;

        public string Title { get; set; }
        public string Poster { get; set; }
        public bool IsWatched { get; set; }
        public DateTime ReleaseYear { get; set; }
        public DateTimeOffset AddedDate { get; set; }

        public Film(string title, string post, bool isWatched, DateTime releaseYear, DateTimeOffset addedDate, int userId)
        {
            Title = title;
            Poster = post;
            IsWatched = isWatched;
            ReleaseYear = releaseYear;
            AddedDate = addedDate;
        }

        public Film(NextFilm.DataAccess.Models.Film filmData)
        {
            Title = filmData.Title;
            Poster = filmData.Poster;
            IsWatched = filmData.IsWatched;
            ReleaseYear = filmData.ReleaseYear;
            AddedDate = filmData.AddedDate;
        }

        public Film(Task<DataAccess.Models.Film> filmData)
        {
            Title = filmData.Result.Title;
            Poster = filmData.Result.Poster;
            IsWatched = filmData.Result.IsWatched;
            ReleaseYear = filmData.Result.ReleaseYear;
            AddedDate = filmData.Result.AddedDate;
        }

        
    }
}
