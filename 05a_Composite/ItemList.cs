/* 	
 * David Kranewitter
 * Simon Hintersonnleitner
*/

using System;
using System.Collections.Generic;
namespace a_Composite
{
	public class ItemList 
	{

		List<ItemList> allItems = new List<ItemList>();
		string name;

		public ItemList(string name)
		{
			this.name = name;
		}

		public void addItemList(ItemList i)
		{
			allItems.Add(i);
		}

		public void removeItemList(ItemList i)
		{
			allItems.Add(i);
		}
	}
}

