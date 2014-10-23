/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	public interface IObservable
	{
		void Register(IObserver o);
		void UnRegister(IObserver o);

	}
}

