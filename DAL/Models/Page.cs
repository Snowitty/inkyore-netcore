namespace inkyore_netcore.DAL.Models
{
    public class Page : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string CoverImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public string Content { get; set; }
        public ContentStatus status { get; set; }
    }


}
