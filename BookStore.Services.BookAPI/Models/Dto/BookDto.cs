namespace BookStore.Services.BookAPI.Models.Dto
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }   
        public string Description { get; set; } 
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
    }
}