/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03
{
	public class TemperaturView:View
	{
		public TemperaturView(string name):base(name)
		{
		}

		public override void printWeather ()
		{
			base.printWeather ();
			Console.WriteLine (temperature);
		}
	}
}

