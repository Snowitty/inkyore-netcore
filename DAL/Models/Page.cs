﻿namespace inkyore_netcore.DAL.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string CoverImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public string Content { get; set; }
        public ContentStatus status { get; set; }
        public bool IsDeleted { get; set; }
    }


}
