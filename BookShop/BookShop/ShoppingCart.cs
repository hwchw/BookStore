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

		public decimal GetPrice()
		{
			decimal sum = 0;
			var discountGroupList = GetDiscountGroupList();
			foreach (var group in discountGroupList)
			{
				sum += GetOriginalGroupPrice(group) * GetDiscount((DiscountType)group.Count);
			}

			return sum;
		}

		private static int GetOriginalGroupPrice(IEnumerable<IProduct> products)
		{
			return products.Sum(product => product.Price);
		}

		private static decimal GetDiscount(DiscountType groupCount)
		{
			switch (groupCount)
			{
				case DiscountType.TwoDistinctBooks:
					return 0.95m;
				case DiscountType.ThreeDistinctBooks:
					return 0.9m;
				case DiscountType.FourDistinctBooks:
					return 0.8m;
				case DiscountType.FiveDistictBooks:
					return 0.75m;
				default:
					return 1;
			}
		}

		private List<List<IProduct>> GetDiscountGroupList()
		{
			var productDiscountGroup = new List<List<IProduct>>();
			var consumeCount = _products.Max(product => product.Quantity);
			for (var i = 1; i <= consumeCount; i++)
			{
				productDiscountGroup.Add(_products.Where(x => x.Quantity - i >= 0).Select(x => x.Item).ToList());
			}
			return productDiscountGroup;
		}
	}
}
