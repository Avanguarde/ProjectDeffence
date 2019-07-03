using System;

namespace News.Data.Models
{
    public class Picture
    {
        public Picture()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public byte[] Data { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}