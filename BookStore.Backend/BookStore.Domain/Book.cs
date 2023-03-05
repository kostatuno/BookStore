using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime YearOfPublication { get; set; }
        public double Weight { get; set; }
        public bool AreIllustrations { get; set; }
        public string Cover { get; set; }
        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
