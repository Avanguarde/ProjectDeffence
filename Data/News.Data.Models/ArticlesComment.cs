namespace News.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using News.Data.Models.Interfaces;

    public class ArticlesComment : IComment
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime CreatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int AuthorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public User Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
