namespace BookLibraryData.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Publisher { get; set; }
        public DateTime YearPublished { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

    }
}
