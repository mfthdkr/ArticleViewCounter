namespace ArticleViewCounter.DTOs.ViewModels
{
    public class ArticleDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int NumberOfViews { get; set; } = 0;
    }
}
