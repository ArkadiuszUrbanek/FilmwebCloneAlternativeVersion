namespace FilmwebCloneBackend.DTOs.Review
{
    public class ReviewUploadDto
    {
        public double Rating { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int FilmId { get; set; }
    }
}
