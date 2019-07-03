using System;

namespace News.Data.Models.Interfaces
{
    public interface IComment
    {
        string Id { get; set; }

        string Content { get; set; }

        DateTime CreatedOn { get; set; }

        int AuthorId { get; set; }
        User Author { get; set; }



    }
}
