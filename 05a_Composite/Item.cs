// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace a_Composite
{
	public abstract class Item:IItem
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

		public void setName(string name)
		{
			this.name = name;
		}

		public float getPrice()
		{
			return price;
		}

		public void setPrice(float price)
		{
			this.price = price;
		}

		public virtual void print(int level)
		{
			for (int i = 0; i < level; i++)
				Console.Write ("  ");

		}
	}
}

