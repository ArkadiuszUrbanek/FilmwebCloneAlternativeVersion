namespace FilmwebCloneBackend.DTOs.Forum
{
    public class ForumPagedResponseDto
    {
        public int PagesCount { get; set; }
        public int ResultsCount { get; set; }
        public int CurrentPageResultsCount { get; set; }
        public class ForumInfo
        {
            public int Id { get; set; }
            public string Name { get; set; } = null!;
            public DateTime CreationDate { get; set; }
            public int MessagesCount { get; set; }
            public class ForumAuthor
            {
                public int Id { get; set; }
                public string FirstName { get; set; } = null!;
                public string LastName { get; set; } = null!;
            }
            public ForumAuthor Author { get; set; } = null!;
        }
        public ICollection<ForumInfo> Forums { get; set; } = null!;
    }
}
