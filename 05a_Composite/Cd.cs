// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace a_Composite
{
	public class Cd:Item
	{
		public Cd (string name, float price):base(name,price)
		{
		}

		public override void print (int level)
		{
			base.print(level);
			Console.WriteLine("<cd name="+ name+ " price="+price+" />");
		}
	}
}

