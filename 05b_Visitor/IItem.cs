// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace b_Visitor
{
	public interface IItem
	{
		void print(int level);
		double getPrice ();
		ItemList getListByName(string listName);
		void accept(AbstractVisitor visitor);
	}
}

