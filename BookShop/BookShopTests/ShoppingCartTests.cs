using System.Collections.Generic;
using BookShop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookShopTests
{
	[TestClass()]
	public class ShoppingCartTests
	{
		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_0_ep3_0_ep4_0_ep5_0_price_should_equal_100()
		{
			//arrange
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100))  
			};
			shoppingCar.AddMutiProducts(books);

			//act
			const int expected = 100;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_1_ep3_0_ep4_0_ep5_0_price_should_equal_190()
		{
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100)),
				new CartItem(new Book(002, "Harry Potter:The Chamber of Secrets", 100))
			};
			shoppingCar.AddMutiProducts(books);

			const int expected = 190;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_1_ep3_1_ep4_0_ep5_0_price_should_equal_270()
		{
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100)),
				new CartItem(new Book(002, "Harry Potter:The Chamber of Secrets", 100)),
				new CartItem(new Book(003, "Harry Potter:The Prisoner of Azkabans", 100))
			};
			shoppingCar.AddMutiProducts(books);

			const int expected = 270;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_1_ep3_1_ep4_1_ep5_0_price_should_equal_320()
		{
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100)),
				new CartItem(new Book(002, "Harry Potter:The Chamber of Secrets", 100)),
				new CartItem(new Book(003, "Harry Potter:The Prisoner of Azkabans", 100)),
				new CartItem(new Book(004, "Harry Potter:The Goblet of Fire", 100))
			};
			shoppingCar.AddMutiProducts(books);

			const int expected = 320;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_1_ep3_1_ep4_1_ep5_1_price_should_equal_375()
		{
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100)),
				new CartItem(new Book(002, "Harry Potter:The Chamber of Secrets", 100)),
				new CartItem(new Book(003, "Harry Potter:The Prisoner of Azkabans", 100)),
				new CartItem(new Book(004, "Harry Potter:The Goblet of Fire", 100)),
				new CartItem(new Book(005, "Harry Potter:The Order of the Phoenix ", 100))
			};
			shoppingCar.AddMutiProducts(books);

			const int expected = 375;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_1_ep3_2_ep4_0_ep5_0_price_should_equal_370()
		{
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100)),
				new CartItem(new Book(002, "Harry Potter:The Chamber of Secrets", 100)),
				new CartItem(new Book(003, "Harry Potter:The Prisoner of Azkabans", 100),2)
			};
			shoppingCar.AddMutiProducts(books);

			const int expected = 370;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Given_HarryPotter_ep1_1_ep2_2_ep3_2_ep4_0_ep5_0_price_should_equal_460()
		{
			var shoppingCar = new ShoppingCart();
			var books = new List<CartItem>
			{
				new CartItem(new Book(001, "Harry Potter:The Philosopher's Stone", 100)),
				new CartItem(new Book(002, "Harry Potter:The Chamber of Secrets", 100),2),
				new CartItem(new Book(003, "Harry Potter:The Prisoner of Azkabans", 100),2)
			};
			shoppingCar.AddMutiProducts(books);

			const int expected = 460;
			var actual = shoppingCar.GetPrice(new HarryPotterDiscountHelper());

			Assert.AreEqual(expected, actual);
		}
	}
}
