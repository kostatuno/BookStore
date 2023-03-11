﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BookStore.Application.Commands
{
    public class CreateBookCommand : IRequest<int> 
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
