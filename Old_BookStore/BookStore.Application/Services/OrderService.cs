using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class OrderService : IOrder
    {
        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetFilteredOrders(string userId = null, OrderBy orderBy = OrderBy.None, int offset = 0, int limit = 10, decimal? minimalPrice = null, decimal? maximalPrice = null, DateTime? minDate = null, DateTime? maxDate = null, string zipCode = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetUserLatestOrders(int count, string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetUserMostPopularBooks(string id)
        {
            throw new NotImplementedException();
        }
    }
}
