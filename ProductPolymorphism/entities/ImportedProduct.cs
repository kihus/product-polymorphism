using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPolymorphism.entities
{
	internal class ImportedProduct : Product
	{
		public double CustomsFee { get; set; }

		public ImportedProduct() { }

		public ImportedProduct(string name, double price, double customsFee) : base(name, price)
		{
			Name = name;
			Price = price; 
			CustomsFee = customsFee;
		}

		private double TotalPrice()
		{
			return Price + CustomsFee;
		}

		public override string PriceTag()
		{
			return $"{Name} $ {TotalPrice()} (Customs fee: $ {CustomsFee})";
		}
	}
}
