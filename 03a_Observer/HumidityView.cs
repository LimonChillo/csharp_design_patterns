using System;

namespace bsp03
{
	public class HumidityView:View
	{
		public HumidityView(string name):base(name)
		{
		}

		public override void printWeather ()
		{
			base.printWeather ();
			Console.WriteLine (" humidity: " + humidity);
		}

	}
}

