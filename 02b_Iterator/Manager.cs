/*
	David Kranewitter
	Simon Hintersonnleinter
*/

using System;
using System.Collections.Generic;

namespace b_Iterator
{
	class Manager
	{
		private static Manager instance;

		private Manager ()
		{
		}


		public static Manager getInstance()
		{
			if (instance == null) 
			{
				instance = new Manager ();
			}
			return instance;
		}


		List<Duck> allDucks = new List<Duck>();

		public void addDuck(Duck d)
		{
			allDucks.Add(d);
		}

		public DuckIterator createIterator()
		{
			return new DuckIterator (allDucks);
		}

	}
}