namespace News.Data.Models.Interfaces
{
    public interface IRating
    {
        string Id { get; set; }

        int Likes { get; set; }

        int Dislikes { get; set; }
    }
}
