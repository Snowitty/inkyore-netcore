﻿namespace inkyore_netcore.DAL.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CovorImage { get; set; }
        public ContentStatus status { get; set; }
    }

}
