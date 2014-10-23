using System;

namespace b_Observer_Delegate
{
	public class View
	{
		public View ()
		{


		}


		public void AskWeatherChanged(WeatherChangeEvent w) 
		{
			Console.Write("The new ask price is:" + w.temperture + "\r\n"); 
		}
	}
}

