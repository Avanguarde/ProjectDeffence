namespace News.Data.Models
{
    using News.Data.Models.Interfaces;

    public class AuthorsRating : IRating
    {
        public string Id { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}