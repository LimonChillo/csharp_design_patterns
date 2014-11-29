/*
	David Kranewitter
	Simon Hintersonnleitner
/* 	
 * David Kranewitter
 * Simon Hintersonnleitner
*/

using System;

namespace b_Visitor
{
	public class DebugVisitor : AbstractVisitor
	{

		public DebugVisitor ()
		{

		}


		public override void visitComposite(ItemList itemList)
		{
			Console.WriteLine("List(name=" + itemList.getName() + ", size=" + itemList.getSize() + ", price=" + itemList.getPrice() + ")");
		}

		public override void visitItem(Item item)
		{

			if (item.GetType() == typeof(Book))
			{
				Book b = item as Book;
				Console.WriteLine("Book(name=" + item.getName() + ", price=" + item.getPrice() + ", isbn=" + b.getIsbn() + ")");
			}
			else 
			{
				Console.WriteLine("Cd(name=" + item.getName()  + ", price=" + item.getPrice() + ")");
			}

		}
			
	}
}

