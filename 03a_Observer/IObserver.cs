using System;

namespace bsp03
{
	public interface IObserver
	{
	
		void update(WheaterChangeEvent w);
	}
}

