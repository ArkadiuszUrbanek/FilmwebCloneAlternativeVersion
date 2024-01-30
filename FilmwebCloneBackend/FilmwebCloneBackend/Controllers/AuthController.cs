using FilmwebCloneBackend.DTOs.Auth;
using FilmwebCloneBackend.Entities;
using FilmwebCloneBackend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace FilmwebCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly FilmwebDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly JwtService _jwtService;
        private readonly EmailService _emailService;
        private readonly IConfiguration _configuration;

        public AuthController(
            FilmwebDbContext context,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            JwtService jwtService,
            EmailService emailService,
            IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
            _emailService = emailService;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<string>> Register([FromBody]UserRegisterDto dto)
        {
            if (await _userManager.Users.AnyAsync(user => user.Email == dto.Email.ToLower()))
            {
                return BadRequest("There already exists an account using the provided email.");
            }

            var user = new User()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.Email.ToLower(),
                Email = dto.Email.ToLower(),
                Gender = dto.Gender,
                BirthDate = dto.BirthDate,
                EmailConfirmed = false,
                CreationDate = DateTime.UtcNow,
            };

            var result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            await _userManager.AddToRoleAsync(user, "User");

            string token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(await _userManager.GenerateEmailConfirmationTokenAsync(user)));
            var callbackUrl = $"{_configuration["Frontend:Url"]}{_configuration["Frontend:EmailConfirmationPath"]}?userId={user.Id}&token={token}";

            await _emailService.SendEmailAsync(
                recipentEmail: user.Email,
                subject: "Confirm your email",
                body: $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>.",
                isBodyHtml: true
            );

            return Ok("Account has been created successfully.");
        }

        [AllowAnonymous]
        [HttpPatch("email-confirm")]
        public async Task<ActionResult> ConfirmEmail(UserConfirmEmailDto dto)
        {
            var user = await _userManager.FindByIdAsync(dto.UserId.ToString());
            if (user == null) return Unauthorized("This email address has not been registered yet.");

            if (user.EmailConfirmed) return BadRequest("Your email was confirmed before. Please login to your account.");

            var decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(dto.Token));
            
            var result = await _userManager.ConfirmEmailAsync(user, decodedToken);
            if (!result.Succeeded) return BadRequest("Email confirmation token is invalid.");
            
            return Ok("Email address has been confirmed successfully.");
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] UserLoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user is null) return BadRequest("Invalid email or password.");
            if (user.EmailConfirmed == false) return Unauthorized("Email is unconfirmed.");

            var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (result.Succeeded == false) return BadRequest("Invalid email or password.");

            return await _jwtService.CreateTokenAsync(user);
        }
    }
}
