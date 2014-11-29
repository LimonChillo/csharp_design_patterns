/* 	
 * David Kranewitter
 * Simon Hintersonnleitner
*/

using System;
using System.IO;

namespace b_Visitor
{
	public class XMLWriterVisitor : AbstractVisitor
	{
		public XMLWriterVisitor ()
		{
		}

		public override bool visitEnter( ItemList itemList )
		{
			Console.WriteLine("<list name=\""+ itemList.getName() + "\">");
			return true;
		}

		public override bool visitLeave( ItemList itemList )
		{
			Console.WriteLine("</list>");
			return true;

		}

		public override bool visit( Item item )
		{
			if (item.GetType() == typeof(Book))
			{
				Book b = item as Book;
				Console.WriteLine("<book name=\""+ item.getName() + "\" price=\""+item.getPrice()+"\" isbn=\""+b.getIsbn()+"\"/>");
			}
			else 
			{
				Console.WriteLine("<cd name=\""+ item.getName()+ "\" price=\""+item.getPrice()+"\"/>");
			}
			return true;

		}
	}
}
	