namespace inkyore_netcore.DAL.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string TagImage { get; set; }
        public bool IsDeleted { get; set; }
    }
}
