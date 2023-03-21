using System.Collections.Generic;

namespace BookStore.Services.BookAPI.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
