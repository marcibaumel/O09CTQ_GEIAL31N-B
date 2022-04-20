using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("FilmTable")]
    public class FilmModel
    {
        public Guid FilmId { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Actors { get; set; }
        public string Poster { get; set; }
        public Boolean IsActive { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public FilmModel(Guid filmId, string title, string plot, DateTime realeaseDate, string actors, string poster, bool isActive, DateTimeOffset createdDate)
        {
            FilmId = filmId;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Plot = plot ?? throw new ArgumentNullException(nameof(plot));
            RealeaseDate = realeaseDate;
            Actors = actors ?? throw new ArgumentNullException(nameof(actors));
            Poster = poster ?? throw new ArgumentNullException(nameof(poster));
            IsActive = isActive;
            CreatedDate = createdDate;
        }
    }
}
