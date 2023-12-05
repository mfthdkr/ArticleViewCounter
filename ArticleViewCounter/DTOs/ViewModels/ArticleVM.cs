namespace ArticleViewCounter.DTOs.ViewModels
{
    public class ArticleVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfViews { get; set; } = 0;
    }
}
