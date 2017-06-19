﻿using System.Collections.Generic;
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
			var actual = shoppingCar.GetPrice();

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
			var actual = shoppingCar.GetPrice();

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
			var actual = shoppingCar.GetPrice();

			Assert.AreEqual(expected, actual);
		}
	}
}