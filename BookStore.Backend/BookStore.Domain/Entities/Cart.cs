﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public class Cart
    {
        public string Id { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
    }
}
