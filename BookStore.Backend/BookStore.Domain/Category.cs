﻿using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
