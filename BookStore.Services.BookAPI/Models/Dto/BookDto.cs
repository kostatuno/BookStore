namespace BookStore.Services.BookAPI.Models.Dto
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }   
        public string Description { get; set; } 
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string ImageUrl { get; set; }
    }
}