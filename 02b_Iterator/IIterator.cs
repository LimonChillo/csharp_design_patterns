using System;

namespace b_Iterator
{
	public interface IIterator
	{
		Duck first();
		Duck next();
		bool isDone();
		Duck currentItem();
	
	}
}

