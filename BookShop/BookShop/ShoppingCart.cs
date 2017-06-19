using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
	public class ShoppingCart
	{
		private List<CartItem> _products;

		public ShoppingCart()
		{
			_products = new List<CartItem>();
		}

		public void AddProduct(CartItem book)
		{
			_products.Add(book);
		}

		public void AddMutiProducts(List<CartItem> books)
		{
			_products.AddRange(books);
		}

		public int GetPrice()
		{
			var price = _products.Sum(product => product.Price);
			if (_products.Count > 1)
			{
				price = (int) (price * 0.95);
			}
			return price;
		}
	}
}
