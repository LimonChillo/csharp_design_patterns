using System;

namespace b_Observer_Delegate
{
	public class Program
	{
		static void Main(string[] args)
		{
			View v1 = new View ();
			Weatherstation w1 = new Weatherstation ();

			Weatherstation.AskWeatherDelegate aDelegate = new Weatherstation.AskWeatherDelegate (v1.AskWeatherChanged);

			w1.AskWeatherChanged += aDelegate;


			w1.AskWeather = 1; 


			w1.AskWeatherChanged -= aDelegate;

		}
	}
}

