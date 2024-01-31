using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmwebCloneBackend.Converters
{
    public class DateTimeToUtcDateTimeConverter : ValueConverter<DateTime, DateTime>
    {
        public DateTimeToUtcDateTimeConverter() : base(dateTime => dateTime.ToUniversalTime(), dateTime => DateTime.SpecifyKind(dateTime, DateTimeKind.Utc))
        {
        }
    }
}
