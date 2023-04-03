using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.BookAPI.Exceptions
{
    public class AutoMapperNoSuchGenreException : AutoMapperMappingException
    {
        public AutoMapperNoSuchGenreException()
        {
        }

        public override string Message => "There isn't such a genre";
    }
}
