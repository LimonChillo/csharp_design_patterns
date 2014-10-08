/*
	David Kranewitter
	Simon Hintersonnleinter
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Iterator
{
	 class DuckIterator : IIterator
	{
		private List<Duck> duckList;
		private int current;

		public DuckIterator (List<Duck> list)
		{
			duckList = list;
		}

		public void first()
		{
			current = 0;
		}

		public void next()
		{
			current++;
		}

		public bool isDone()
		{
			return current >= duckList.Count();
		}

		public Duck currentItem()
		{
			if (isDone()) 
			{
				throw new Exception("Iterator is on the end!");
			}
			return duckList[current];
		}
	}
}

