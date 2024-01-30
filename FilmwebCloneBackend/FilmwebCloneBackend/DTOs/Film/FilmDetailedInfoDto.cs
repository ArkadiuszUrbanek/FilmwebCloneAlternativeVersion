using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.DTOs.Film
{
    public class FilmDetailedInfoDto
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
        public int ReviewsCount { get; set; }
        public double AverageRating { get; set; }
    }
}
