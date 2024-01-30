using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.Entities
{
    public class PersonFilmPosition
    {
        public int Id { get; set; }
        public EPosition Position { get; set; }

        //Foreign keys
        public int PersonId { get; set; }
        public int FilmId { get; set; }

        //Navigation properties
        public Film Film { get; set; } = null!;
        public Person Person { get; set; } = null!;
    }
}
