/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03
{
	interface ISubject
	{
		 void registerObserver(IObserver o);
		 bool removeObserver (IObserver o);
		 void notifyObservers ();
	}
}

