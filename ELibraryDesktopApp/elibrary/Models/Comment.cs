namespace ELibrary.Models
{
    public class Comment
    {
        public string CommentedBook { get; set; }
        public string UserCommented { get; set; }
        public int Rate { get; set; }
        public bool IsApproved { get; set; }
        public string Text { get; set; }
        
    }
}