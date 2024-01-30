using FilmwebCloneBackend.DTOs.Forum;
using FilmwebCloneBackend.DTOs.Message;
using FilmwebCloneBackend.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FilmwebCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly FilmwebDbContext _context;
        public MessageController(FilmwebDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<int>> AddMessage([FromBody] MessageUploadDto dto)
        {
            var message = new Message()
            {
                Text = dto.Text,
                CreationDate = DateTime.UtcNow,
                UserId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)!.Value),
                ForumId = dto.ForumId
            };

            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();

            return Ok(message.Id);
        }

        [Authorize]
        [HttpDelete("{messageId}/delete")]
        public async Task<ActionResult<int>> RemoveMessage([FromRoute] int messageId)
        {
            var message = new Message { Id = messageId };
            _context.Messages.Attach(message);
            _context.Messages.Remove(message);
            var affectedRows = await _context.SaveChangesAsync();

            if (affectedRows <= 0) return NotFound();
            else return Ok(affectedRows);
        }
    }
}
