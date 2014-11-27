// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace a_Composite
{
	public interface IItem
	{
		void print(int level);
		double getPrice ();
		ItemList getListByName(string listName);
	}
}

