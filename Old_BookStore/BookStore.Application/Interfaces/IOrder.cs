using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using BookStore.Domain.Enums;

namespace BookStore.Application.Interfaces
{
	public interface IOrder
	{
		void CreateOrder(Order order);
        Order GetById(int orderId);
		IEnumerable<Order> GetByUserId(string userId);
		IEnumerable<Order> GetAll();
		IEnumerable<Order> GetUserLatestOrders(int count, string userId);
		IEnumerable<Book> GetUserMostPopularBooks(string id);
		IEnumerable<Order> GetFilteredOrders(
			string userId=null,
			OrderBy orderBy = OrderBy.None,
			int offset=0,
			int limit=10,
			decimal? minimalPrice = null,
			decimal? maximalPrice = null,
			DateTime? minDate = null,
			DateTime? maxDate = null,
			string zipCode = null
			);
	}
}