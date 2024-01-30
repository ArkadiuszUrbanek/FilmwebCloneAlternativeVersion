namespace FilmwebCloneBackend.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public DateTime CreationDate { get; set; }

        //Foreign keys
        public int UserId { get; set; }
        public int ForumId { get; set; }

        //Navigation properties
        public User User { get; set; } = null!;
        public Forum Forum { get; set; } = null!;
    }
}
