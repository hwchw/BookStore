using System.Collections.Generic;

namespace BookShop
{
	public class Book : IGoods
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
		public CartItem(IGoods item)
		{
			Item = item;
			Quantity = 1;
			Price = Quantity * Item.Price;
		}

		public IGoods Item { get; private set; }
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

	public interface IGoods
	{
		int Id { get; }
		string Name { get; }
		int Price { get; }
	}
}