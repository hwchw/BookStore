using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
	public class ShoppingCart
	{
		private List<CartItem> _items;

		public ShoppingCart()
		{
			_items = new List<CartItem>();
		}

		public void AddBook(CartItem book)
		{
			_items.Add(book);
		}

		public void AddMultiBooks(List<CartItem> books)
		{
			_items.AddRange(books);
		}

		public int GetPrice()
		{
			var price = _items.Sum(item => item.Price);
			if (_items.Count > 1)
			{
				price = (int) (price * 0.95);
			}
			return price;
		}
	}
}
