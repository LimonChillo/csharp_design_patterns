/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;

namespace bsp03b
{
	public class HumidityView:View
	{
		public HumidityView(string name):base(name)
		{
		}

		public override void printWeather ()
		{
			base.printWeather ();
			Console.WriteLine (humidity);
		}
	}
}