using System.Collections.Generic;
using System.Linq;

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

		public double GetPrice()
		{
			var originalPrice = _products.Sum(product => product.Price);
			var discount = GetDiscount();

			return originalPrice * discount;
		}

		private double GetDiscount()
		{
			if (_products.Count == 2)
				return 0.95;
			if (_products.Count == 3)
				return 0.9;
			if (_products.Count == 4)
				return 0.8;
			return 1;
		}
	}
}
