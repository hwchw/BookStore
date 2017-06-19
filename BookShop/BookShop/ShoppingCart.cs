using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
	public class ShoppingCart
	{
		private List<CartItem> _books;

		public ShoppingCart()
		{
			_books = new List<CartItem>();
		}

		public void AddBook(CartItem book)
		{
			_books.Add(book);
		}

		public void AddMultiBooks(List<CartItem> books)
		{
			_books.AddRange(books);
		}

		public int GetPrice()
		{
			return 100;
		}
	}
}
