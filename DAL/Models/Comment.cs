namespace inkyore_netcore.DAL.Models
{
    public class Comment : BaseEntity
    {
        public int ArticleId { get; set; }
        public int PageID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
