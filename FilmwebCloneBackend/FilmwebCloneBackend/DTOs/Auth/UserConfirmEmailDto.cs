using Microsoft.AspNetCore.Mvc;

namespace FilmwebCloneBackend.DTOs.Auth
{
    public class UserConfirmEmailDto
    {
        public int UserId { get; set; }
        public string Token { get; set; }
    }
}
