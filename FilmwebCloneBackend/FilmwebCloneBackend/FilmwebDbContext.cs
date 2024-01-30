using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FilmwebCloneBackend.Entities;

namespace FilmwebCloneBackend
{
    public class FilmwebDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        protected readonly IConfiguration _configuration;
        public DbSet<Message> Messages { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<PersonFilmPosition> PersonFilmPositions { get; set; }
        public DbSet<Person> Persons { get; set; }

        public FilmwebDbContext(IConfiguration configuration, DbContextOptions<FilmwebDbContext> options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entityBuilder =>
            {
                entityBuilder.Property(userEntity => userEntity.FirstName).IsRequired(true);
                entityBuilder.Property(userEntity => userEntity.LastName).IsRequired(true);
                entityBuilder.Property(userEntity => userEntity.Gender).IsRequired(true);
                entityBuilder.Property(userEntity => userEntity.BirthDate).IsRequired(true);
                entityBuilder.Property(userEntity => userEntity.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
            });

            modelBuilder.Entity<Message>(entityBuilder =>
            {
                entityBuilder.HasKey(messageEntity => messageEntity.Id);
                entityBuilder.Property(messageEntity => messageEntity.Text).IsRequired(true);
                entityBuilder.Property(messageEntity => messageEntity.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entityBuilder.Property(messageEntity => messageEntity.UserId).IsRequired(true);
                entityBuilder.Property(messageEntity => messageEntity.ForumId).IsRequired(true);
                entityBuilder.HasOne(messageEntity => messageEntity.User).WithMany(userEntity => userEntity.Messages).HasForeignKey(messageEntity => messageEntity.UserId);
                entityBuilder.HasOne(messageEntity => messageEntity.Forum).WithMany(forumEntity => forumEntity.Messages).HasForeignKey(messageEntity => messageEntity.ForumId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Forum>(entityBuilder =>
            {
                entityBuilder.HasKey(forumEntity => forumEntity.Id);
                entityBuilder.Property(forumEntity => forumEntity.Name).IsRequired(true);
                entityBuilder.Property(forumEntity => forumEntity.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entityBuilder.Property(forumEntity => forumEntity.UserId).IsRequired(true);
                entityBuilder.HasOne(forumEntity => forumEntity.User).WithMany(userEntity => userEntity.Forums).HasForeignKey(forumEntity => forumEntity.UserId);
            });

            modelBuilder.Entity<Review>(entityBuilder =>
            {
                entityBuilder.HasKey(reviewEntity => reviewEntity.Id);
                entityBuilder.Property(reviewEntity => reviewEntity.Rating).IsRequired(true);
                entityBuilder.Property(reviewEntity => reviewEntity.Title).IsRequired(true);
                entityBuilder.Property(reviewEntity => reviewEntity.Description).IsRequired(true);
                entityBuilder.Property(reviewEntity => reviewEntity.CreationDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entityBuilder.Property(reviewEntity => reviewEntity.UserId).IsRequired(true);
                entityBuilder.Property(reviewEntity => reviewEntity.FilmId).IsRequired(true);
                entityBuilder.HasOne(reviewEntity => reviewEntity.User).WithMany(userEntity => userEntity.Reviews).HasForeignKey(reviewEntity => reviewEntity.UserId);
                entityBuilder.HasOne(reviewEntity => reviewEntity.Film).WithMany(filmEntity => filmEntity.Reviews).HasForeignKey(reviewEntity => reviewEntity.FilmId);
            });

            modelBuilder.Entity<Film>(entityBuilder =>
            {
                entityBuilder.HasKey(filmEntity => filmEntity.Id);
                entityBuilder.Property(filmEntity => filmEntity.Title).IsRequired(true);
                entityBuilder.Property(filmEntity => filmEntity.Subtitle).IsRequired(false);
                entityBuilder.Property(filmEntity => filmEntity.Description).IsRequired(true);
                entityBuilder.Property(filmEntity => filmEntity.ReleaseDate).IsRequired(true);
                entityBuilder.Property(filmEntity => filmEntity.Duration).IsRequired(true);
                entityBuilder.Property(filmEntity => filmEntity.PosterPath).IsRequired(true);
                entityBuilder.Property(filmEntity => filmEntity.BannerPath).IsRequired(true);
                entityBuilder.Property(filmEntity => filmEntity.Genre).IsRequired(true);
            });

            modelBuilder.Entity<PersonFilmPosition>(entityBuilder =>
            {
                entityBuilder.HasKey(personFilmPositionEntity => personFilmPositionEntity.Id);
                entityBuilder.Property(personFilmPositionEntity => personFilmPositionEntity.Position).IsRequired(true);
                entityBuilder.Property(personFilmPositionEntity => personFilmPositionEntity.PersonId).IsRequired(true);
                entityBuilder.Property(personFilmPositionEntity => personFilmPositionEntity.FilmId).IsRequired(true);
                entityBuilder.HasOne(personFilmPositionEntity => personFilmPositionEntity.Person).WithMany(personEntity => personEntity.PersonFilmPositions).HasForeignKey(personFilmPositionEntity => personFilmPositionEntity.PersonId);
                entityBuilder.HasOne(personFilmPositionEntity => personFilmPositionEntity.Film).WithMany(filmEntity => filmEntity.PersonFilmPositions).HasForeignKey(personFilmPositionEntity => personFilmPositionEntity.FilmId);
            });

            modelBuilder.Entity<Person>(entityBuilder =>
            {
                entityBuilder.HasKey(personEntity => personEntity.Id);
                entityBuilder.Property(personEntity => personEntity.FirstName).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.LastName).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.Gender).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.Nationality).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.Height).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.BirthDate).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.Description).IsRequired(true);
                entityBuilder.Property(personEntity => personEntity.PicturePath).IsRequired(true);
            });

            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>[]
                {
                    new IdentityRole<int>()
                    {
                        Id = 1,
                        Name = "User",
                        NormalizedName = "USER"
                    }, 
                    new IdentityRole<int>()
                    { 
                        Id = 2,
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    }
                }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<Enum>().HaveConversion<string>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(
                _configuration.GetConnectionString("FilmwebDb"),
                new MySqlServerVersion(new Version(8, 0, 35))//,
                //options => options.EnableRetryOnFailure(
                //    maxRetryCount: 10,
                //    maxRetryDelay: TimeSpan.FromSeconds(30),
                //    errorNumbersToAdd: null)
            );
            //optionsBuilder.UseMySql(_configuration.GetConnectionString("FilmwebDb"), ServerVersion.AutoDetect(_configuration.GetConnectionString("FilmwebDb")));
        }
    }
}
