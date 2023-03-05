using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
