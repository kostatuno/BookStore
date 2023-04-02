namespace BookStore.Web.Models
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }   
        public string Description { get; set; } 
        public string Genre { get; set; }
        public string ImageUrl { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not BookDto obj2 || !obj.GetType().Equals(GetType()))
            {
                return false;
            }
            return obj2.BookId == BookId &&
                obj2.Name == Name &&
                obj2.Price == Price &&
                obj2.Description == Description &&
                obj2.Genre == Genre && 
                obj2.ImageUrl == ImageUrl;
        }
    }
}