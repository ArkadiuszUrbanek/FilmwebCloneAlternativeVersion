using FilmwebCloneBackend.DTOs.Forum;
using FilmwebCloneBackend.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static FilmwebCloneBackend.DTOs.Forum.ForumMessagesInfoDto;
using static FilmwebCloneBackend.DTOs.Forum.ForumMessagesInfoDto.MessageInfo;
using static FilmwebCloneBackend.DTOs.Forum.ForumPagedResponseDto;
using static FilmwebCloneBackend.DTOs.Forum.ForumPagedResponseDto.ForumInfo;

namespace FilmwebCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly FilmwebDbContext _context;
        public ForumController(FilmwebDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<ForumPagedResponseDto>> GetForums([FromQuery] ForumPaginationParametersDto dto)
        {
            var forumsQuery = _context.Forums
                .Include(forumEntity => forumEntity.User)
                .Include(forumEntity => forumEntity.Messages)
                .Select(forumEntity => new
                {
                    Forum = forumEntity,
                    MessagesCount = forumEntity.Messages.Count()
                });

            if (dto.SortingOrder == EForumSortOrder.Ascending)
            {
                if (dto.SortingProperty == EForumSortProperty.CreationDate) forumsQuery = forumsQuery.OrderBy(a => a.Forum.CreationDate.Date).ThenBy(a => a.Forum.CreationDate.TimeOfDay);
                if (dto.SortingProperty == EForumSortProperty.MessagesCount) forumsQuery = forumsQuery.OrderBy(a => a.MessagesCount);

            }
            else if (dto.SortingOrder == EForumSortOrder.Descending)
            {
                if (dto.SortingProperty == EForumSortProperty.CreationDate) forumsQuery = forumsQuery.OrderByDescending(a => a.Forum.CreationDate.Date).ThenByDescending(a => a.Forum.CreationDate.TimeOfDay);
                if (dto.SortingProperty == EForumSortProperty.MessagesCount) forumsQuery = forumsQuery.OrderByDescending(a => a.MessagesCount);
            }

            var anonymousResults = await forumsQuery
                .Skip((dto.PageNumber - 1) * dto.PageSize)
                .Take(dto.PageSize)
                .ToListAsync();

            var resultsCount = await _context.Forums.CountAsync();
            
            var responseDto = new ForumPagedResponseDto
            {
                PagesCount = (int)Math.Ceiling(resultsCount / (double)dto.PageSize),
                ResultsCount = resultsCount,
                CurrentPageResultsCount = anonymousResults.Count(),
                Forums = anonymousResults.Select(a => new ForumInfo()
                {
                    Id = a.Forum.Id,
                    Name = a.Forum.Name,
                    CreationDate = a.Forum.CreationDate,
                    MessagesCount = a.MessagesCount,
                    Author = new ForumAuthor()
                    {
                        Id = a.Forum.User.Id,
                        FirstName = a.Forum.User.FirstName,
                        LastName = a.Forum.User.LastName
                    }
                }).ToList()
            };

            return Ok(responseDto);
        }

        [AllowAnonymous]
        [HttpGet("{forumId}/messages/all")]
        public async Task<ActionResult<ICollection<ForumMessagesInfoDto>>> GetAll([FromRoute] int forumId)
        {
            var forumMessagesInfo = await _context.Forums
                .Where(forumEntity => forumEntity.Id == forumId)
                .Include(forumEntity => forumEntity.Messages)
                .ThenInclude(messageEntity => messageEntity.User)
                .Select(forumEntity => new ForumMessagesInfoDto()
                {
                    ForumName = forumEntity.Name,
                    Messages = forumEntity.Messages
                        .Select(messageEntity => new MessageInfo()
                        {
                            Id = messageEntity.Id,
                            Text = messageEntity.Text,
                            CreationDate = messageEntity.CreationDate,
                            Author = new MessageAuthor()
                            {
                                Id = messageEntity.User.Id,
                                FirstName = messageEntity.User.FirstName,
                                LastName = messageEntity.User.LastName,
                                Gender = messageEntity.User.Gender
                            }
                        })
                .OrderBy(messageEntity => messageEntity.CreationDate.Date)
                .ThenBy(reviewEntity => reviewEntity.CreationDate.TimeOfDay)
                .ToList()
                })
                .SingleOrDefaultAsync();

            if (forumMessagesInfo == null) return NotFound();
            else return Ok(forumMessagesInfo);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<int>> AddForum([FromBody] ForumUploadDto dto)
        {
            var userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)!.Value);

            var forum = new Forum()
            {
                Name = dto.Name,
                CreationDate = DateTime.UtcNow,
                UserId = userId,
                Messages = new List<Message>() {
                    new Message() 
                    {
                        Text = dto.InitialMessageText,
                        UserId = userId
                    } 
                }
            };

            await _context.Forums.AddAsync(forum);
            await _context.SaveChangesAsync();

            return Ok(forum.Id);
        }

        [Authorize]
        [HttpDelete("{forumId}/delete")]
        public async Task<ActionResult<int>> RemoveForum([FromRoute] int forumId)
        {
            var forum = new Forum { Id = forumId };
            _context.Forums.Attach(forum);
            _context.Forums.Remove(forum);
            var affectedRows = await _context.SaveChangesAsync();

            if (affectedRows <= 0) return NotFound();
            else return Ok(affectedRows);
        }
    }
}
