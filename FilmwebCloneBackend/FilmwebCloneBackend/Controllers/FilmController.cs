using FilmwebCloneBackend.DTOs.Film;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmwebCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly FilmwebDbContext _context;

        public FilmController(FilmwebDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet("{filmId}/poster")]
        public ActionResult<string> GetPosterUri([FromRoute] int filmId)
        {
            return Ok($"{Request.Scheme}://{Request.Host}{Request.PathBase}/Static/Films/Posters/{filmId}.jpg");
        }

        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<ActionResult<ICollection<FilmBasicInfoDto>>> GetAll()
        {
            var films = await _context.Films
                .Select(filmEntity => new FilmBasicInfoDto()
                {
                    Id = filmEntity.Id,
                    Title = filmEntity.Title,
                    Subtitle = filmEntity.Subtitle,
                    ReleaseDate = filmEntity.ReleaseDate,
                    Duration = filmEntity.Duration,
                    PosterPath = filmEntity.PosterPath,
                    Genre = filmEntity.Genre,
                    ReviewsCount = filmEntity.Reviews.Count,
                    AverageRating = filmEntity.Reviews.Any() ? filmEntity.Reviews.Average(review => review.Rating) : 0
                })
                .ToListAsync();

            return Ok(films);
        }

        [AllowAnonymous]
        [HttpGet("{filmId}")]
        public async Task<ActionResult<FilmDetailedInfoDto>> GetFilm([FromRoute] int filmId)
        {
            var film = await _context.Films
                .Where(filmEntity => filmEntity.Id == filmId)
                .Select(filmEntity => new FilmDetailedInfoDto()
                {
                    Id = filmEntity.Id,
                    Title = filmEntity.Title,
                    Subtitle = filmEntity.Subtitle,
                    Description = filmEntity.Description,
                    ReleaseDate = filmEntity.ReleaseDate,
                    Duration = filmEntity.Duration,
                    PosterPath = filmEntity.PosterPath,
                    BannerPath = filmEntity.BannerPath,
                    Genre = filmEntity.Genre,
                    ReviewsCount = filmEntity.Reviews.Count,
                    AverageRating = filmEntity.Reviews.Any() ? filmEntity.Reviews.Average(review => review.Rating) : 0
                })
                .SingleAsync();

            return Ok(film);
        }
    }
}
