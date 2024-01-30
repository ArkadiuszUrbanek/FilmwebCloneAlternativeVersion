using FilmwebCloneBackend.Entities.Enums;

namespace FilmwebCloneBackend.DTOs.Auth
{
    public class UserRegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EGender Gender { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
