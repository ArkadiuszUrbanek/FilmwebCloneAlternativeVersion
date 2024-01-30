using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Subtitle { get; set; }
        public string Description { get; set; } = null!;
        public DateOnly ReleaseDate { get; set; }
        public TimeOnly Duration { get; set; }
        public string PosterPath { get; set; } = null!;
        public string BannerPath { get; set; } = null!;
        public EGenre Genre { get; set; }

        //Navigation properties
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<PersonFilmPosition> PersonFilmPositions { get; set; } = new List<PersonFilmPosition>();
    }
}
