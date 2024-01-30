using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.DTOs.Person
{
    public class PersonDetailedInfoDto
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
        public HashSet<EPosition> Positions { get; set; } = new HashSet<EPosition>();
    }
}
