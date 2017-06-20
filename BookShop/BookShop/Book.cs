using System.Collections.Generic;

namespace BookShop
{
	public class Book : IProduct
	{
		public Book(int id, string bookName, int price)
		{
			Id = id;
			Name = bookName;
			Price = price;
		}

		public int Id { get; private set; }
		public string Name { get; private set; }
		public int Price { get; private set; }
	}

	public class CartItem
	{
		public CartItem(IProduct item, int optionalQuantity = 1)
		{
			Item = item;
			Quantity = optionalQuantity;
			Price = Quantity * Item.Price;
		}

		public IProduct Item { get; private set; }
		public int Quantity { get; private set; }
		public int Price { get; private set; }

		public void QuantityUp()
		{
			Quantity++;
			Price = Quantity * Item.Price;
		}		
		
		public void QuantityDown()
		{
			Quantity--;
			Price = Quantity * Item.Price;
		}
	}

	public interface IProduct
	{
		int Id { get; }
		string Name { get; }
		int Price { get; }
	}

	enum DiscountType
	{
		TwoDistinctBooks = 2,
		ThreeDistinctBooks,
		FourDistinctBooks,
		FiveDistictBooks
	}
}