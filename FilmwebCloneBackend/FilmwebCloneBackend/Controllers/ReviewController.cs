using FilmwebCloneBackend.DTOs.Review;
using FilmwebCloneBackend.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static FilmwebCloneBackend.DTOs.Review.ReviewInfoDto;

namespace FilmwebCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly FilmwebDbContext _context;
        public ReviewController(FilmwebDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<ActionResult<ICollection<ReviewInfoDto>>> GetAll([FromQuery] int filmId)
        {
            var reviews = await _context.Reviews
                .Where(reviewEntity => reviewEntity.FilmId == filmId)
                .Include(reviewEntity => reviewEntity.User)
                .Select(reviewEntity => new ReviewInfoDto()
                {
                    Id = reviewEntity.Id,
                    Rating = reviewEntity.Rating,
                    Title = reviewEntity.Title,
                    Description = reviewEntity.Description,
                    CreationDate = reviewEntity.CreationDate,
                    Author = new ReviewAuthorInfo() 
                    {
                        Id = reviewEntity.User.Id,
                        FirstName = reviewEntity.User.FirstName,
                        LastName = reviewEntity.User.LastName,
                        Gender = reviewEntity.User.Gender
                    }
                })
                .OrderByDescending(reviewEntity => reviewEntity.CreationDate.Date)
                .ThenByDescending(reviewEntity => reviewEntity.CreationDate.TimeOfDay)
                .ToListAsync();

            return Ok(reviews);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<int>> AddReview([FromBody] ReviewUploadDto dto)
        {
            //Console.WriteLine(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "brak");

            /*var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var securityToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;
            Console.WriteLine(securityToken?.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value ?? "brak");*/

            var review = new Review()
            {
                Rating = dto.Rating,
                Title = dto.Title,
                Description = dto.Description,
                CreationDate = DateTime.UtcNow,
                UserId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)!.Value),
                FilmId = dto.FilmId
            };

            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();

            return Ok(review.Id);
        }

        [Authorize]
        [HttpDelete("{reviewId}/delete")]
        public async Task<ActionResult> RemoveReview([FromRoute] int reviewId)
        {
            var review = new Review { Id = reviewId };
            _context.Reviews.Attach(review);
            _context.Reviews.Remove(review);
            var affectedRows = await _context.SaveChangesAsync();

            if (affectedRows <= 0) return NotFound();
            else return Ok(affectedRows);
        }
    }
}
