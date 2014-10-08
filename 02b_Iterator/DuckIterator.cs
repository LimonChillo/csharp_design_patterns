using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Iterator
{
	public class DuckIterator : IIterator
	{
		private List<Duck> duckList;
		private long current;

		public DuckIterator ()
		{

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
			if (isDone ()) {
				trow IteratorOutOfBounds;
			}
			return duckList [current];
		}
	}
}

