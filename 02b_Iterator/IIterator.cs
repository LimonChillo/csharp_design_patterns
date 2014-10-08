using System;

namespace b_Iterator
{
	interface IIterator
	{
		 void first();
		 void next();
		 bool isDone();
		 Duck currentItem();
	
	}
}

