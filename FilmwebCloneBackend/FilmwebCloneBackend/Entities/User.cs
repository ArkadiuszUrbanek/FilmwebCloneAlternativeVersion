using FilmwebCloneBackend.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace FilmwebCloneBackend.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public EGender Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateTime CreationDate { get; set; }

        //Navigation properties
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Forum> Forums { get; set; } = new List<Forum>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}