using System.Collections.Generic;
using System.Linq;

namespace BookShop
{
	public class HarryPotterDiscountHelper : IDiscountHelper
	{
		private List<CartItem> _products;

		public void SetProduct(List<CartItem> products)
		{
			_products = products;
		}

		public decimal GetPrice()
		{
			return GetDiscountGroupList().Sum(discountGroup => GetTotalProductPrice(discountGroup) * GetDiscount((DiscountType)discountGroup.Count));
		}

		private static int GetTotalProductPrice(IEnumerable<IProduct> products)
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

		private IEnumerable<List<IProduct>> GetDiscountGroupList()
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