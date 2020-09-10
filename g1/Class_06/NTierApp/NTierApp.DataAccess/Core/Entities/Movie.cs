using NTierApp.DataAccess.Core.Enums;

namespace NTierApp.DataAccess.Core.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public Rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }
    }
}
