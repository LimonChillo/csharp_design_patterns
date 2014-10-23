/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	public interface IObserver
	{
		void update(WheaterChangeEvent w);
	}
}

