using System;

namespace bsp03
{
	class View:IObserver
	{

		private string name; 

		public View (string name)
		{
			this.name = name;
		}

		public void update()
		{

		}
	}
}

