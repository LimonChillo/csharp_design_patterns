using System;
using System.Collections.Generic;
namespace bsp01
{
	 class Manager
	{
		public Manager ()
		{
		}


		List<Duck> allDucks = new List<Duck>();

		public void addDuck(Duck d)
		{
			allDucks.Add(d);
		}
		public void printAllDucks()
		{
			foreach (Duck d in allDucks) 
			{
				d.display ();
				d.quack ();
			}
		}
	}
}

