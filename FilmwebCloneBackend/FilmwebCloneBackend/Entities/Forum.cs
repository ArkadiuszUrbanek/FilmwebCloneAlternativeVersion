namespace FilmwebCloneBackend.Entities
{
    public class Forum
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        
        //Foreign keys
        public int UserId { get; set; }

        //Navigation properties
        public User User { get; set; } = null!;
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
