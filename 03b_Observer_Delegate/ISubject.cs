/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	interface ISubject
	{
		void registerObserver (View v);
		bool removeObserver (View v);
		void notifyObservers ();
	}
}

