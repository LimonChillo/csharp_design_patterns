// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace b_Visitor
{
	public class Cd:Item
	{
		public Cd (string name, double price):base(name,price)
		{
		}

		public override void print (int level)
		{
			base.print(level);
			Console.WriteLine("<cd name="+ name+ " price="+price+" />");
		}
	}
}

