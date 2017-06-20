using System.Collections.Generic;

namespace BookShop
{
	public class ShoppingCart
	{
		private readonly List<CartItem> _products;

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

		public decimal GetPrice(IDiscountHelper discountHelper)
		{
			var totalPrice = discountHelper.GetPrice();
			return totalPrice;
		}

	}
}
