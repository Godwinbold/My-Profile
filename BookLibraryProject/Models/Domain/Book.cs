namespace BookLibraryProject.Models.Domain
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Review { get; set; }
    }
}
