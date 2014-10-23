/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	public interface ISubject
	{
		void registerObserver (IObserver o);
		bool removeObserver (IObserver o);
		void notifyObservers ();
	}
}

