using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.DTOs.Forum
{
    public class ForumMessagesInfoDto
    {
        public string ForumName { get; set; } = null!;
        public class MessageInfo
        {
            public int Id { get; set; }
            public string Text { get; set; } = null!;
            public DateTime CreationDate { get; set; }
            public class MessageAuthor
            {
                public int Id { get; set; }
                public string FirstName { get; set; } = null!;
                public string LastName { get; set; } = null!;
                public EGender Gender { get; set; }
            }
            public MessageAuthor Author { get; set; } = null!;
        }
        public ICollection<MessageInfo> Messages { get; set; } = null!;
    }
}
