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
			switch (_products.Count)
			{
				case 2:
					return 0.95;
				case 3:
					return 0.9;
				case 4:
					return 0.8;
				case 5:
					return 0.75;
			}
			return 1;
		}
	}
}
