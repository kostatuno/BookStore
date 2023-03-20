using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.ProductAPI.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime YearOfPublication { get; set; }
        [Range(1, 2000)] // grams
        public double Weight { get; set; }
        public bool AreIllustrations { get; set; }
        public string Cover { get; set; }
        public int NumberOfPages { get; set; }
        [Range(1, 5000)]
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
