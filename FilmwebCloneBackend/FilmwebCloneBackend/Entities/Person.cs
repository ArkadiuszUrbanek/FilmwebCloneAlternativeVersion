using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public EGender Gender { get; set; }
        public ENationality Nationality { get; set; }
        public int Height { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Description { get; set; } = null!;
        public string PicturePath { get; set; } = null!;

        //Navigation properties
        public ICollection<PersonFilmPosition> PersonFilmPositions { get; set; } = new List<PersonFilmPosition>();
    }
}
