namespace BookStore.Web.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime YearOfPublication { get; set; }
        public double Weight { get; set; }
        public bool AreIllustrations { get; set; }
        public string Cover { get; set; }
        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not BookViewModel obj2 || !obj.GetType().Equals(GetType()))
            {
                return false;
            }
            return obj2.BookId == BookId &&
                obj2.Name == Name &&
                obj2.Price == Price &&
                obj2.Description == Description &&
                obj2.Genre == Genre &&
                obj2.ImageUrl == ImageUrl &&
                obj2.YearOfPublication == YearOfPublication &&
                obj2.InStock == InStock &&
                obj2.NumberOfPages == NumberOfPages &&
                obj2.Cover == Cover &&
                obj2.Weight == Weight &&
                obj2.AreIllustrations == AreIllustrations;
        }
    }
}