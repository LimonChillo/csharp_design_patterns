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

		public virtual bool visitEnter( ItemList itemList ){
			return false;
		}
		public virtual bool visitLeave( ItemList itemList ){
			return false;
		} 
		public virtual bool visit( Item item ){
			return false;
		}
	}
}

