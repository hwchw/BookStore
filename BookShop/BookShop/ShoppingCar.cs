using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
	public class ShoppingCar
	{
		private List<Book> _books;

		public ShoppingCar()
		{
			_books = new List<Book>();
		}

		public void AddBook(Book book)
		{
			_books.Add(book);
		}

		public void AddMultiBooks(List<Book> books)
		{
			_books.AddRange(books);
		}

		public int GetPrice()
		{
			return 100;
		}
	}
}
