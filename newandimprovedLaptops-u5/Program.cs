using newandimprovedLaptops_u5.Data;
using newandimprovedLaptops_u5.Models;

using BrandandLaptopContext context= new BrandandLaptopContext();

namespace newandimprovedLaptops_u5
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();

			Brand mapple = new Brand()
			{
				Id = 00001,
				Name = "Mapple"
			};

			//BrandList = new()
			//{
			//	new Brand(00001,"Mapple"),
			//	new Brand(00002,"MikeSoft"),
			//	new Brand(00003,"Dall"),
			//	new Brand(00004,"GL")
			//};

			//LaptopList = new()
			//{
			//	new Laptop(235432,"MapleBook", BrandList[0], 1300, 2022),
			//	new Laptop(235433, "MappleBook Professional", BrandList[0], 2500, 2023),
			//	new Laptop(183292, "Ripple Tab", BrandList[1], 850, 2019),
			//	new Laptop(183293, "Ripple Lap", BrandList[1], 2050, 2021),
			//	new Laptop(743237, "Longatude", BrandList[2], 1300, 2022),
			//	new Laptop(743238, "AllenWare", BrandList[2], 2000, 2022),
			//	new Laptop(549345, "kiloGram", BrandList[3], 1900, 2022),
			//	new Laptop(549346, "Extra", BrandList[3], 2300, 2021)
			//};
		}
	}
}