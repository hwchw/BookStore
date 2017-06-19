namespace BookShop
{
	public class Book
	{
		public Book(int id, string bookName, int price)
		{
			Id = id;
			BookName = bookName;
			Price = price;
		}

		public int Id { get; private set; }
		public string BookName { get; private set; }
		public int Price { get; private set; }
	}
}