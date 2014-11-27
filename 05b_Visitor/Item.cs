// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace b_Visitor
{
	public abstract class Item:IItem
	{
		protected string name;
		protected double price;

		public Item (string name, double price)
		{
			this.name = name;
			this.price = price;
		}

		override void accept(DebugVisitor visitor) 
		{
			visitor.visitItem(this);
		}

		public string getName()
		{
			return name;
		}

		public void setName(string name)
		{
			this.name = name;
		}

		public double getPrice()
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
		public ItemList getListByName(string listName)
		{
			return null;
		}
	}
}

