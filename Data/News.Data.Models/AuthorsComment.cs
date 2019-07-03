namespace News.Data.Models
{
    using System;

    using News.Data.Models.Interfaces;

    public class AuthorsComment : IComment
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public int AuthorId { get; set; }

        public User Author { get; set; }
    }
}