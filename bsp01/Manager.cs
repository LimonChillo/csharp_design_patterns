using System;
using System.Collections.Generic;
namespace bsp01
{
	public class Manager
	{
		public Manager ()
		{
		}


		List<Duck> allDucks = new List<Duck>();

		public void addDuck(Duck d, Quack q)
		{
			allDucks.Add(d);
		}
	}
}

