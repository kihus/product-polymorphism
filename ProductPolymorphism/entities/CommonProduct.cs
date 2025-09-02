using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPolymorphism.entities
{
	internal class CommonProduct : Product
	{
		public CommonProduct() { }

		public CommonProduct(string name, double price) : base(name, price)
		{
			Name = name;
			Price = price;
		}

		public override string PriceTag()
		{
			return $"{Name} $ {Price.ToString("F2")}";
		}
	}
}
