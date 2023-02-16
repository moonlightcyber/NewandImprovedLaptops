namespace newandimprovedLaptops_u5.Models
{
	public class Laptop
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public int BrandId { get; set; }
		public int Price { get; set; }
		public int Year { get; set; }

		public Laptop()
		{

		}
		public Laptop(int id, string model, int brandid, int price, int year)
		{
			Id = id;
			Model = model;
			BrandId = brandid;
			Price = price;
			Year = year;
		}
	}
}
