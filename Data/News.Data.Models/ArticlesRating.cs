namespace News.Data.Models
{
    using System;

    using News.Data.Models.Interfaces;

    public class ArticlesRating : IRating
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Likes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Dislikes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
