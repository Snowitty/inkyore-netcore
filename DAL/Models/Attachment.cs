namespace inkyore_netcore.DAL.Models
{
    public class Attachment : BaseEntity
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
        public string FilePath { get; set; }
    }
}
