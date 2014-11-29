/* 	
 * David Kranewitter
 * Simon Hintersonnleitner
*/

using System;
using System.Collections.Generic;
namespace b_Visitor
{
	public class ItemList:IItem 
	{

		List<IItem> allItems = new List<IItem>();
		string name;

		public void accept(AbstractVisitor visitor) 
		{
			visitor.visitComposite(this);
			foreach (IItem i in allItems) {
				i.accept(visitor);
			}
		}

		public bool acceptXMLVisitor( AbstractVisitor visitor )
		{
			if ( visitor.visitEnter( this ) ) 
			{
				foreach (IItem i in allItems) {
					i.acceptXMLVisitor(visitor);
				}
			}

			return visitor.visitLeave( this );
		}

		public ItemList(string name)
		{
			this.name = name;
		}

		public void addItem(IItem i)
		{
			allItems.Add(i);
		}

		public void removeItem(IItem i)
		{
			allItems.Remove(i);
		}
		public int getSize()
		{
			return allItems.Count;
		}

		public string getName()
		{
			return name;
		}


		public double getPrice()
		{
			double sum = 0;

			foreach (IItem i in allItems) 
			{
				sum += i.getPrice();
			}

			return sum;
		}
			
		public ItemList getListByName(string listName)
		{
			if (listName == name) 
			{
				return this;
			}
			else 
			{
				foreach (IItem i in allItems) 
				{
					if (i.getListByName (listName) != null) 
					{
						return i.getListByName (listName);
					}
				}

			}
				
			return null;
		}



		public void print(int level)
		{
			for (int i = 0; i < level; i++)
				Console.Write ("  ");

			Console.WriteLine("<list name="+name+">");
			foreach (IItem i in allItems) 
			{
				i.print(level+1);
			}
			for (int i = 0; i < level; i++)
				Console.Write ("  ");

			Console.WriteLine("</list>");

		}

	}
}

