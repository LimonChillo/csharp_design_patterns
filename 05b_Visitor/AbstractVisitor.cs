/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace b_Visitor
{
	public class AbstractVisitor
	{
		virtual void visitComposite(ItemList itemList);
		virtual void visitItem(Item item);
		//virtual void visitCD(IItem item);
		//virtual void visitBook(IItem item);
	}
}

