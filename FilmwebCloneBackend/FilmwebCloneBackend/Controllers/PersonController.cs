using FilmwebCloneBackend.DTOs.Actor;
using FilmwebCloneBackend.DTOs.Person;
using FilmwebCloneBackend.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmwebCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly FilmwebDbContext _context;
        public PersonController(FilmwebDbContext context)
        {

            _context = context;

        }

        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<ActionResult<ICollection<PersonBasicInfoDto>>> GetAll([FromQuery] HashSet<EPosition> personPositions, [FromQuery] int filmId)
        {
            var people = await _context.Persons
                .Include(personEntity => personEntity.PersonFilmPositions)
                .SelectMany(personEntity => personEntity.PersonFilmPositions
                    .Where(personFilmPositionEntity => personPositions.Contains(personFilmPositionEntity.Position) && personFilmPositionEntity.FilmId == filmId)
                    .Select(personFilmPositionEntity => new PersonBasicInfoDto()
                    {
                        Id = personEntity.Id,
                        FirstName = personEntity.FirstName,
                        LastName = personEntity.LastName,
                        PicturePath = personEntity.PicturePath,
                        Positions = new HashSet<EPosition>(personEntity.PersonFilmPositions.Select(personFilmPositionEntity => personFilmPositionEntity.Position))
                    })
                )
                .ToListAsync();

            return Ok(people);
        }

        [AllowAnonymous]
        [HttpGet("{personId}")]
        public async Task<ActionResult<PersonDetailedInfoDto?>> GetOne([FromRoute] int personId)
        {
            var person = await _context.Persons
                .Where(personEntity => personEntity.Id == personId)
                .Include(personEntity => personEntity.PersonFilmPositions)
                .Select(personEntity => new PersonDetailedInfoDto()
                {
                    Id = personEntity.Id,
                    FirstName = personEntity.FirstName,
                    LastName = personEntity.LastName,
                    Gender = personEntity.Gender,
                    Nationality = personEntity.Nationality,
                    Height = personEntity.Height,
                    BirthDate = personEntity.BirthDate,
                    Description = personEntity.Description,
                    PicturePath = personEntity.PicturePath,
                    Positions = personEntity.PersonFilmPositions
                        .Select(personFilmPositionEntity => personFilmPositionEntity.Position)
                        .Distinct()
                        .ToHashSet()
                })
                .SingleOrDefaultAsync();

            if (person == null) return NotFound();
            else return Ok(person);
        }
    }
}
