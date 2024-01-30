namespace FilmwebCloneBackend.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreationDate { get; set; }

        //Foreign keys
        public int UserId { get; set; }
        public int FilmId { get; set; }

        //Navigation properties
        public User User { get; set; } = null!;
        public Film Film { get; set; } = null!;
    }
}
