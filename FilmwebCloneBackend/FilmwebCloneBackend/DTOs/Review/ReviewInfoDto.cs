using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.DTOs.Review
{
    public class ReviewInfoDto
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public class ReviewAuthorInfo
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = null!;
            public string LastName { get; set; } = null!;
            public EGender Gender { get; set; }
        }
        public ReviewAuthorInfo Author { get; set; } = null!;
    }
}
