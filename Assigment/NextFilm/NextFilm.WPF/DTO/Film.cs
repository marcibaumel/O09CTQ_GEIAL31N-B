using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.WPF.DTO
{
    public class Film
    {
        public string Title { get; set; }
        public string Poster { get; set; }
        public bool IsWatched { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DateTimeOffset AddedDate { get; set; }

        public Film(string title, string post, bool isWatched, DateTime releasedDate, DateTimeOffset addedDate, int userId)
        {
            Title = title;
            Poster = post;
            IsWatched = isWatched;
            ReleasedDate = releasedDate;
            AddedDate = addedDate;
        }

        public Film(NextFilm.DataAccess.Models.Film filmData)
        {
            Title = filmData.Title;
            Poster = filmData.Poster;
            IsWatched = filmData.IsWatched;
            ReleasedDate = filmData.ReleaseYear;
            AddedDate = filmData.AddedDate;
        }

        public NextFilm.DataAccess.Models.Film converDtoToFilm()
        {
            return new NextFilm.DataAccess.Models.Film(this.Title, this.Poster, this.IsWatched, this.ReleasedDate, this.AddedDate);
        }

        public Film(Task<DataAccess.Models.Film> filmData)
        {
            Title = filmData.Result.Title;
            Poster = filmData.Result.Poster;
            IsWatched = filmData.Result.IsWatched;
            ReleasedDate = filmData.Result.ReleaseYear;
            AddedDate = filmData.Result.AddedDate;
        }

        
    }
}
