namespace News.Data.Models
{
    using System.Collections.Generic;

    public class User : ApplicationUser
    {
        public User()
        {
            this.Comments = new HashSet<AuthorsComment>();
            this.Articles = new HashSet<Article>();
        }

        public string Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public override string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Role Role { get; set; }

        public string RatingId { get; set; }

        public AuthorsRating Rating { get; set; }

        public string PictureId { get; set; }

        public Picture Picture { get; set; }

        public virtual IReadOnlyCollection<AuthorsComment> Comments { get; set; }

        public virtual IReadOnlyCollection<Article> Articles { get; set; }
    }
}
