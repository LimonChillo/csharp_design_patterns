// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace a_Composite
{
	public abstract class Item
	{
		protected string name;
		protected float price;

		public Item (string name, float price)
		{
			this.name = name;
			this.price = price;
		}

		public string getName()
		{
			return name;
		}

		public string setName(string name)
		{
			this.name = name;
		}

		public string getPrice()
		{
			return price;
		}

		public string setPrice(float price)
		{
			this.price = price;
		}
	}
}

