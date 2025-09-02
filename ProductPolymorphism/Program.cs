using ProductPolymorphism.entities;
using System.Globalization;

var product = new List<Product>();

Console.Write("Enter the number of products: " );
var numProd = int.Parse(Console.ReadLine() ?? "0");

for(int i = 1; i < numProd; i++)
{
	Console.WriteLine($"Product #{i} data: ");

	Console.Write("Common, used or imported (c/u/i)?");
	var CoUsIm = char.Parse(Console.ReadLine() ?? "c");

	Console.Write("Name: ");
	var name = Console.ReadLine() ?? "0";

	Console.Write("Price: ");
	var price = double.Parse(Console.ReadLine() ?? "0");


	switch (CoUsIm.ToString())
	{
		case "i":
			Console.Write("Customs fee: ");
			var customsFee = double.Parse(Console.ReadLine() ?? "0");

			product.Add(new ImportedProduct(name, price, customsFee));
			break;

		case "u":
			Console.Write("Manufacture date (DD/MM/YYYY): ");
			var manufactureDate = DateTime.ParseExact(Console.ReadLine() ?? "0", "dd/MM/yyyy", CultureInfo.InvariantCulture);

			product.Add(new UsedProduct(name, price, manufactureDate));
			break;


		case "c":
			product.Add(new CommonProduct(name, price));
			break;
		default:
			throw new Exception("error");
			
	}
}

foreach(var item in product)
{
	Console.WriteLine(item);
}