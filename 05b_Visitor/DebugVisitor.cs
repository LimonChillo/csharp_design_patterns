/*
	David Kranewitter
	Simon Hintersonnleitner
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
			Console.WriteLine("yolo");
		}

		public override void visitItem(Item item)
		{

			if (item.GetType() == typeof(Book))
			{
				Console.WriteLine("Book");
			}
			else 
			{
				Console.WriteLine("CD");
			}

		}

		public override void display()
		{

		}
	}
}

