/* 	
 * David Kranewitter
 * Simon Hintersonnleitner
*/

using System;
using System.Collections.Generic;
namespace a_Composite
{
	public class ItemList:IItem 
	{

		List<IItem> allItems = new List<IItem>();
		string name;

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
			allItems.Add(i);
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

