/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03
{
	public interface ISubject
	{
		void registerObserver ();
		void removeObserver ();
		void notifyObservers ();
	}
}

