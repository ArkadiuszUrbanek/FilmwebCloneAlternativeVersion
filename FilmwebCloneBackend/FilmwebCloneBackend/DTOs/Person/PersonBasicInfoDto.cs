using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.DTOs.Actor
{
    public class PersonBasicInfoDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PicturePath { get; set; } = null!;
        public HashSet<EPosition> Positions { get; set; } = new HashSet<EPosition>();
    }
}
