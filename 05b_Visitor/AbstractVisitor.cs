/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace b_Visitor
{
	public abstract class AbstractVisitor
	{
		public virtual void visitComposite(ItemList itemList){
		}
		public virtual void visitItem(Item item){
		}
		public virtual void display (){
		}
		//virtual void visitCD(IItem item);

		//virtual void visitBook(IItem item);
	}
}

