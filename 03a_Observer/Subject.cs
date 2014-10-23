using System;

namespace bsp03
{
	public interface Subject
	{
		void registerObserver ();
		void removeObserver ();
		void notifyObservers ();
	}
}

