using newandimprovedLaptops_u5.Models;
using Microsoft.EntityFrameworkCore;

namespace newandimprovedLaptops_u5.Data
{
	public class BrandandLaptopContext : DbContext
	{
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Laptop> Laptops { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=laptopshop;Integrated Security=True;");
		}
	}
}
