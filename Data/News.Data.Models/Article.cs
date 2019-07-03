namespace News.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Article
    {

        public Article()
        {
            this.Comments = new HashSet<ArticlesComment>();
            this.Pictures = new HashSet<Picture>();
            this.CratedOn = DateTime.UtcNow;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }

        public string Content { get; set; }

        public string Genre { get; set; }

        public DateTime CratedOn { get; set; }

        public string RatingId { get; set; }

        public ArticlesRating Rating { get; set; }

        public virtual ICollection<ArticlesComment> Comments { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        //public ICollection<Video> Videos { get; set; }




    }
}