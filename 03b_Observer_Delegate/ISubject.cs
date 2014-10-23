/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	public interface ISubject
	{
		void registerObserver ();
		void removeObserver ();
		void notifyObservers ();
	}
}

