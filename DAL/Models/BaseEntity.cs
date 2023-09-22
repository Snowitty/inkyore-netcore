namespace inkyore_netcore.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }

    public enum ContentStatus
    {
        Draft,
        Published
    }
}
